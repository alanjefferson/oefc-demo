using BlueChip.Models;
using BlueChip.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BlueChip.Controllers
{
	[ApiController]
	[Route("[controller]")]
	[Produces("application/json")]
	public class DeliveryController : ControllerBase
	{
		private readonly IConfiguration _config;
		private readonly IHttpClientFactory _httpClientFactory;
		private readonly ILogger<DeliveryController> _logger;
		private readonly BlueChipInfo _blueChipInfo;
		private readonly DiscaFacilInfo _discaFacilInfo;
		private readonly MyTrackingInfo _myTrackingInfo;

		protected readonly LogOcorrenciaFechadoRepository _logOcorFechadoRepository;
		protected readonly LogIntegracaoServicoRepository _logIntegracaoServicoRepository;
		protected readonly UsuarioRepository _usuarioRepository;

		public DeliveryController(ILogger<DeliveryController> logger, IConfiguration config, IHttpClientFactory httpClientFactory, ContextDb context)
		{
			_logger = logger;
			_config = config;
			_httpClientFactory = httpClientFactory;

			_blueChipInfo = new BlueChipInfo();
			_config.GetSection("BlueChipInfo").Bind(_blueChipInfo);

			_discaFacilInfo = new DiscaFacilInfo();
			_config.GetSection("DiscaFacilInfo").Bind(_discaFacilInfo);

			_myTrackingInfo = new MyTrackingInfo();
			_config.GetSection("MyTrackingInfo").Bind(_myTrackingInfo);

			_usuarioRepository = new UsuarioRepository(context, _discaFacilInfo);
			_logIntegracaoServicoRepository = new LogIntegracaoServicoRepository(context);
			_logOcorFechadoRepository = new LogOcorrenciaFechadoRepository(context, _discaFacilInfo, _httpClientFactory, _myTrackingInfo, _logIntegracaoServicoRepository);
		}

		[HttpGet]
		public IActionResult Index()
		{
			return Ok(new APIVersion());
		}

		[HttpPost]
		[Route("notes")]
		public async Task<IActionResult> PostNotes([FromHeader] string token, [FromBody] JsonElement content)
		{
			if(string.IsNullOrEmpty(token))
				return Unauthorized(Util.Util.BuildErrorMessage("Token inválido"));

			string user = Util.Util.GetUserFromToken(token);
			List<Usuario> lstUsuario = await _usuarioRepository.GetUserByLogin(user);

			if(lstUsuario.Count <= 0)
				return Unauthorized(Util.Util.BuildErrorMessage("Token inválido"));

			_logger.LogInformation(string.Format("Usuário identificado no token: {0}", lstUsuario[0].USUA_NM_NOME));

			string json = content.ToString();
			_logger.LogInformation(string.Format("Json recebido: {0}", json));

			NoteRequest deliveryRequest = JsonConvert.DeserializeObject<NoteRequest>(json);
						
			return Ok(await _logOcorFechadoRepository.Update(deliveryRequest));
		}

		[HttpPost]
		[Route("orders")]
		public async Task<IActionResult> PostOrders([FromHeader] string token)
		{
			if (string.IsNullOrEmpty(token))
				return Unauthorized(Util.Util.BuildErrorMessage("Token inválido"));

			string user = Util.Util.GetUserFromToken(token);
			List<Usuario> lstUsuario = await _usuarioRepository.GetUserByLogin(user);

			if (lstUsuario.Count <= 0)
				return Unauthorized(Util.Util.BuildErrorMessage("Token inválido"));

			_logger.LogInformation(string.Format("Usuário identificado no token: {0}", lstUsuario[0].USUA_NM_NOME));

			return Ok(await _logOcorFechadoRepository.Send());
		}
	}
}
