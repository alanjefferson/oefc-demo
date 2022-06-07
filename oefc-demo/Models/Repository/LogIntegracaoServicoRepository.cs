using BlueChip.Context;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlueChip.Models
{
	public class LogIntegracaoServicoRepository
	{
		protected readonly ContextDb _context;

		public LogIntegracaoServicoRepository(ContextDb context)
		{
			_context = context;
		}

		public async Task<LogIntegracaoServico> Insert(string json, string response, long? LOOF_CD_ID_FK)
		{
			List<LogIntegracaoServico> logIntegracaoServico = await _context.LogIntegracaoServico.FromSqlRaw("SELECT SEQ_LOG_INTEGRACAO_SERVICO.nextval AS LOIS_CD_ID_PK, null AS LOIS_TX_SOLICITACAO, null AS LOIS_TX_RETORNO, null AS LOIS_DT_EXECUCAO, 1 AS TIIS_CD_ID_FK, 1 AS LOOF_CD_ID_FK FROM dual;").ToListAsync();
			logIntegracaoServico.First().LOIS_DT_EXECUCAO = DateTime.Now;
			logIntegracaoServico.First().LOIS_TX_SOLICITACAO = json;
			logIntegracaoServico.First().LOIS_TX_RETORNO = response;
			logIntegracaoServico.First().LOIS_DT_EXECUCAO = DateTime.Now;
			logIntegracaoServico.First().TIIS_CD_ID_FK = 1;
			logIntegracaoServico.First().LOOF_CD_ID_FK = LOOF_CD_ID_FK;

			_context.LogIntegracaoServico.Add(logIntegracaoServico.First());
			_context.SaveChanges();

			return logIntegracaoServico.First();
		}
	}
}
