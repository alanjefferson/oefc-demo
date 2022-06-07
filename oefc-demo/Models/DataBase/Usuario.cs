using System.ComponentModel.DataAnnotations;

namespace BlueChip.Models
{
	public class Usuario
	{
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
		[Key]
		public long? USUA_CD_ID_PK { get; set; }
		public string? USUA_NM_LOGIN { get; set; }
		public string? USUA_NM_NOME { get; set; }
		public long? USUA_CD_ID_GEST1_FK { get; set; }
		public long? USUA_CD_ID_GEST2_FK { get; set; }
		public long? OPER_CD_ID_FK { get; set; }
		public string? USUA_TX_CPF { get; set; }
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
	}
}