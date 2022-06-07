using BlueChip.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Net.Http;
using System.Text;
using System.Net.Http.Json;

namespace BlueChip.Models
{
	public class LogOcorrenciaFechadoRepository
	{
		private readonly IHttpClientFactory _httpClientFactory;

		protected readonly ContextDb _context;
		protected readonly DiscaFacilInfo _discaFacilInfo;
		protected readonly MyTrackingInfo _myTrackingInfo;

		protected readonly LogIntegracaoServicoRepository _logIntegracaoServicoRepository;

		public LogOcorrenciaFechadoRepository(ContextDb context, DiscaFacilInfo discaFacilInfo, IHttpClientFactory httpClientFactory, MyTrackingInfo myTrackingInfo, LogIntegracaoServicoRepository logIntegracaoServicoRepository)
		{
			_context = context;
			_discaFacilInfo = discaFacilInfo;
			_myTrackingInfo = myTrackingInfo;
			_httpClientFactory = httpClientFactory;
			_logIntegracaoServicoRepository = logIntegracaoServicoRepository;
		}

		#region Recebimento de Dados Externos

		public async Task<DeliveryNotesResponse> Update(NoteRequest deliveryRequest)
		{
			NoteResponse deliveryResponse;
			List<NoteResponse> deliveryList = new();

			foreach (Note item in deliveryRequest.entregas)
			{
				List<LogOcorrenciaFechado> lstLogOcorResult = await GetRegistersToUpdate(item.numeroPedido);
				deliveryResponse = (lstLogOcorResult.Count > 0) ? await UpdateRegister(lstLogOcorResult, item) : Util.Util.BuildErrorMessage("Registro não encontrado na base de dados",item);
				deliveryList.Add(deliveryResponse);
			}

			DeliveryNotesResponse deliveryNotesResponse = new();
			deliveryNotesResponse.DeliveryList = deliveryList;

			return deliveryNotesResponse;
		}

		#region private methods
		private async Task<List<LogOcorrenciaFechado>> GetRegistersToUpdate(string orderNumber)
		{
			List<LogOcorrenciaFechado> lstLogOcorResult = await _context.LogOcorrenciaFechado.Where(x =>
				   (x.PROD_CD_ID_FK == _discaFacilInfo.PROD_CD_ID_FK)
				&& (x.PROJ_CD_ID_FK == _discaFacilInfo.PROJ_CD_ID_FK)
				&& (x.CAMP_CD_ID_FK == _discaFacilInfo.CAMP_CD_ID_FK)
				&& (x.LOOF_TX_CAMPO56 == orderNumber)
			).ToListAsync();

			return lstLogOcorResult;
		}
		
		private async Task<NoteResponse> UpdateRegister(List<LogOcorrenciaFechado> logOcorFechado, Note note)
		{
			NoteResponse deliveryNote = new();

			LogOcorrenciaFechado logOcorUpdate = logOcorFechado.First();
			logOcorUpdate.LOOF_TX_CAMPO58 = note.dataOcorrencia;
			logOcorUpdate.LOOF_TX_CAMPO59 = note.nomeMotorista;
			logOcorUpdate.LOOF_TX_CAMPO60 = note.placaVeiculo;
			logOcorUpdate.LOOF_TX_CAMPO61 = note.codOcorrencia;
			logOcorUpdate.LOOF_TX_CAMPO62 = note.descOcorrencia;
			logOcorUpdate.LOOF_TX_CAMPO63 = note.iccid;
			logOcorUpdate.LOOF_TX_CAMPO64 = note.linkRastreio;
			logOcorUpdate.LOOF_TX_CAMPO65 = note.cnpjCpfDes;

			_context.LogOcorrenciaFechado.Update(logOcorUpdate);
			await _context.SaveChangesAsync();

			deliveryNote.CnpjCpf = logOcorUpdate.LOOF_TX_CAMPO65;
			deliveryNote.RequestNumber = logOcorUpdate.LOOF_TX_CAMPO56;
			deliveryNote.ShippingNumber = logOcorUpdate.LOOF_TX_CAMPO57;
			deliveryNote.MessageCode = "1";
			deliveryNote.Message = "OK";

			return deliveryNote;
		}
		#endregion

		#endregion

		#region Envio de Dados para API Externa

		public async Task<DeliveryOrdersResponse> Send()
		{
			DeliveryOrdersResponse deliveryOrdersResponse = new() { DeliveryList = new List<OrderResponse>() };

			List<LogOcorrenciaFechado> lstLogOcorResult = await GetClosedRegisters();
			foreach (LogOcorrenciaFechado logOcorFechado in lstLogOcorResult)
			{
				OrderResponse orderResponse = await ExternalSending(logOcorFechado);
				deliveryOrdersResponse.DeliveryList.Add(orderResponse);

			}

			return deliveryOrdersResponse;
		}

		#region private methods
		private async Task<List<LogOcorrenciaFechado>> GetClosedRegisters()
		{
			List<LogOcorrenciaFechado> lstLogOcorResult = await _context.LogOcorrenciaFechado.Where(x =>
							   (x.PROD_CD_ID_FK == _discaFacilInfo.PROD_CD_ID_FK)
							&& (x.PROJ_CD_ID_FK == _discaFacilInfo.PROJ_CD_ID_FK)
							&& (x.CAMP_CD_ID_FK == _discaFacilInfo.CAMP_CD_ID_FK)
							&& (x.LOOF_TX_STATUS == "Encerrado")
							&& (x.LOOF_TX_CAMPO100 != "Enviado")
						).ToListAsync();

			return lstLogOcorResult;
		}

		private Order GetJsonOrderRequest(LogOcorrenciaFechado logOcorFechado)
		{
			Order order = new();
			order.cnpjCd = (logOcorFechado.LOOF_TX_CAMPO35 != null) ? logOcorFechado.LOOF_TX_CAMPO35 : string.Empty;
			order.nomeMotorista = (logOcorFechado.LOOF_TX_CAMPO59 != null) ? logOcorFechado.LOOF_TX_CAMPO59 : string.Empty;
			order.placaVeiculo = (logOcorFechado.LOOF_TX_CAMPO60 != null) ? logOcorFechado.LOOF_TX_CAMPO60 : string.Empty;
			order.tipoOpe = (logOcorFechado.LOOF_TX_CAMPO94 != null) ? logOcorFechado.LOOF_TX_CAMPO94 : string.Empty;
			order.numeroPedido = (logOcorFechado.LOOF_TX_CAMPO56 != null) ? logOcorFechado.LOOF_TX_CAMPO56 : string.Empty;
			order.numeroRemessa = (logOcorFechado.LOOF_TX_CAMPO57 != null) ? logOcorFechado.LOOF_TX_CAMPO57 : string.Empty;
			order.qtdVolumes = (logOcorFechado.LOOF_TX_CAMPO95 != null) ? logOcorFechado.LOOF_TX_CAMPO95 : string.Empty;
			order.cnpjCpfDes = (logOcorFechado.LOOF_TX_CAMPO65 != null) ? logOcorFechado.LOOF_TX_CAMPO65 : string.Empty;
			order.nomeDes = (logOcorFechado.LOOF_TX_CAMPO27 != null) ? logOcorFechado.LOOF_TX_CAMPO27 : string.Empty;
			order.endDes = (logOcorFechado.LOOF_TX_CAMPO75 != null) ? logOcorFechado.LOOF_TX_CAMPO75 : string.Empty;
			order.baiDes = (logOcorFechado.LOOF_TX_CAMPO78 != null) ? logOcorFechado.LOOF_TX_CAMPO78 : string.Empty;
			order.cidDes = (logOcorFechado.LOOF_TX_CAMPO79 != null) ? logOcorFechado.LOOF_TX_CAMPO79 : string.Empty;
			order.ufDes = (logOcorFechado.LOOF_TX_CAMPO80 != null) ? logOcorFechado.LOOF_TX_CAMPO80 : string.Empty;
			order.numDes = (logOcorFechado.LOOF_TX_CAMPO76 != null) ? logOcorFechado.LOOF_TX_CAMPO76 : string.Empty;
			order.cepDes = (logOcorFechado.LOOF_TX_CAMPO74 != null) ? logOcorFechado.LOOF_TX_CAMPO74 : string.Empty;
			order.cplDes = (logOcorFechado.LOOF_TX_CAMPO77 != null) ? logOcorFechado.LOOF_TX_CAMPO77 : string.Empty;

			return order;
		}
		
		private async Task<OrderResponse> ExternalSending(LogOcorrenciaFechado logOcorFechado)
		{
			string strJsonResponse = string.Empty;
			OrderResponse orderResponse = new() { CodMensagem = "2" };

			var orderRequest = new OrderRequest() { entregas = new List<Order>() };
			orderRequest.entregas.Add(GetJsonOrderRequest(logOcorFechado));
			string strJsonBody = JsonSerializer.Serialize(orderRequest);
			
			var request = new HttpRequestMessage(HttpMethod.Post, _myTrackingInfo.Url);
			request.Headers.Add("token", _myTrackingInfo.Token);
			request.Content = new StringContent(strJsonBody, Encoding.UTF8, "application/json");

			var client = _httpClientFactory.CreateClient();
			HttpResponseMessage response = await client.SendAsync(request);

			if (response.IsSuccessStatusCode)
			{
				DeliveryOrdersResponse deliveryOrdersResponseAPI = await response.Content.ReadFromJsonAsync<DeliveryOrdersResponse>();
				strJsonResponse = JsonSerializer.Serialize(deliveryOrdersResponseAPI);

				if (deliveryOrdersResponseAPI.DeliveryList != null && deliveryOrdersResponseAPI.DeliveryList.Count > 0)
				{
					orderResponse = deliveryOrdersResponseAPI.DeliveryList[0];

					if (orderResponse.CodMensagem == "1")
						UpdateStatusRegister(logOcorFechado);
				}
				else
					orderResponse.Mensagem = "Lista de entregas inválida.";
			}
			else
			{
				orderResponse.Mensagem = string.Format("Retorno inválido da API. StatusCode: {0}", response.StatusCode);

				DeliveryOrdersResponse deliveryOrdersResponseAPI = await response.Content.ReadFromJsonAsync<DeliveryOrdersResponse>();
				strJsonResponse = JsonSerializer.Serialize(deliveryOrdersResponseAPI);
			}

			LogIntegracaoServico logIntegracaoServico = await _logIntegracaoServicoRepository.Insert(strJsonBody, strJsonResponse, logOcorFechado.LOOF_CD_ID_PK);

			return orderResponse;
		}

		private async void UpdateStatusRegister(LogOcorrenciaFechado logOcorFechado)
		{
			LogOcorrenciaFechado logOcorUpdate = logOcorFechado;
			logOcorUpdate.LOOF_TX_CAMPO100 = "Enviado";

			_context.LogOcorrenciaFechado.Update(logOcorUpdate);
			await _context.SaveChangesAsync();
		}

		#endregion

		#endregion
	}
}
