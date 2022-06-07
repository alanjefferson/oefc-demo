using System;
using System.ComponentModel.DataAnnotations;

namespace BlueChip.Models
{
	public class LogIntegracaoServico
	{
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
		[Key]
		public long? LOIS_CD_ID_PK { get; set; }
		public DateTime? LOIS_DT_EXECUCAO { get; set; }
		public string? LOIS_TX_SOLICITACAO { get; set; }
		public string? LOIS_TX_RETORNO { get; set; }
		public long? TIIS_CD_ID_FK { get; set; }
		public long? LOOF_CD_ID_FK { get; set; }
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
	}
}
