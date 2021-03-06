using System;
using System.ComponentModel.DataAnnotations;

namespace BlueChip.Models
{
	public class LogOcorrenciaFechado
	{
		[Key]
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
		public long? LOOF_CD_ID_PK { get; set; }
		public long? PROD_CD_ID_FK { get; set; }
		public long? PROJ_CD_ID_FK { get; set; }
		public long? CAMP_CD_ID_FK { get; set; }
		public long? CAVA_CD_ID_FK { get; set; }
		public long? ESTR_CD_ID_FK { get; set; }
		public long? USUA_CD_ID_FK { get; set; }
		public long? USUA_GEST1_CD_ID_FK { get; set; }
		public long? USUA_GEST2_CD_ID_FK { get; set; }
		public DateTime? LOOF_DT_CADASTRO { get; set; }
		public string? LOOF_TX_STATUS { get; set; }
		public string? LOOF_TX_STATUS_ANTERIOR { get; set; }
		public string? LOOF_TX_CAMPO_CHAVE { get; set; }
		public string? LOOF_TX_CAMPO1 { get; set; }
		public string? LOOF_TX_CAMPO2 { get; set; }
		public string? LOOF_TX_CAMPO3 { get; set; }
		public string? LOOF_TX_CAMPO4 { get; set; }
		public string? LOOF_TX_CAMPO5 { get; set; }
		public string? LOOF_TX_CAMPO6 { get; set; }
		public string? LOOF_TX_CAMPO7 { get; set; }
		public string? LOOF_TX_CAMPO8 { get; set; }
		public string? LOOF_TX_CAMPO9 { get; set; }
		public string? LOOF_TX_CAMPO10 { get; set; }
		public string? LOOF_TX_CAMPO11 { get; set; }
		public string? LOOF_TX_CAMPO12 { get; set; }
		public string? LOOF_TX_CAMPO13 { get; set; }
		public string? LOOF_TX_CAMPO14 { get; set; }
		public string? LOOF_TX_CAMPO15 { get; set; }
		public string? LOOF_TX_CAMPO16 { get; set; }
		public string? LOOF_TX_CAMPO17 { get; set; }
		public string? LOOF_TX_CAMPO18 { get; set; }
		public string? LOOF_TX_CAMPO19 { get; set; }
		public string? LOOF_TX_CAMPO20 { get; set; }
		public string? LOOF_TX_CAMPO21 { get; set; }
		public string? LOOF_TX_CAMPO22 { get; set; }
		public string? LOOF_TX_CAMPO23 { get; set; }
		public string? LOOF_TX_CAMPO24 { get; set; }
		public string? LOOF_TX_CAMPO25 { get; set; }
		public string? LOOF_TX_CAMPO26 { get; set; }
		public string? LOOF_TX_CAMPO27 { get; set; }
		public string? LOOF_TX_CAMPO28 { get; set; }
		public string? LOOF_TX_CAMPO29 { get; set; }
		public string? LOOF_TX_CAMPO30 { get; set; }
		public string? LOOF_TX_CAMPO31 { get; set; }
		public string? LOOF_TX_CAMPO32 { get; set; }
		public string? LOOF_TX_CAMPO33 { get; set; }
		public string? LOOF_TX_CAMPO34 { get; set; }
		public string? LOOF_TX_CAMPO35 { get; set; }
		public string? LOOF_TX_CAMPO36 { get; set; }
		public string? LOOF_TX_CAMPO37 { get; set; }
		public string? LOOF_TX_CAMPO38 { get; set; }
		public string? LOOF_TX_CAMPO39 { get; set; }
		public string? LOOF_TX_CAMPO40 { get; set; }
		public string? LOOF_TX_CAMPO41 { get; set; }
		public string? LOOF_TX_CAMPO42 { get; set; }
		public string? LOOF_TX_CAMPO43 { get; set; }
		public string? LOOF_TX_CAMPO44 { get; set; }
		public string? LOOF_TX_CAMPO45 { get; set; }
		public string? LOOF_TX_CAMPO46 { get; set; }
		public string? LOOF_TX_CAMPO47 { get; set; }
		public string? LOOF_TX_CAMPO48 { get; set; }
		public string? LOOF_TX_CAMPO49 { get; set; }
		public string? LOOF_TX_CAMPO50 { get; set; }
		public string? LOOF_TX_CAMPO51 { get; set; }
		public string? LOOF_TX_CAMPO52 { get; set; }
		public string? LOOF_TX_CAMPO53 { get; set; }
		public string? LOOF_TX_CAMPO54 { get; set; }
		public string? LOOF_TX_CAMPO55 { get; set; }
		public string? LOOF_TX_CAMPO56 { get; set; }
		public string? LOOF_TX_CAMPO57 { get; set; }
		public string? LOOF_TX_CAMPO58 { get; set; }
		public string? LOOF_TX_CAMPO59 { get; set; }
		public string? LOOF_TX_CAMPO60 { get; set; }
		public string? LOOF_TX_CAMPO61 { get; set; }
		public string? LOOF_TX_CAMPO62 { get; set; }
		public string? LOOF_TX_CAMPO63 { get; set; }
		public string? LOOF_TX_CAMPO64 { get; set; }
		public string? LOOF_TX_CAMPO65 { get; set; }
		public string? LOOF_TX_CAMPO66 { get; set; }
		public string? LOOF_TX_CAMPO67 { get; set; }
		public string? LOOF_TX_CAMPO68 { get; set; }
		public string? LOOF_TX_CAMPO69 { get; set; }
		public string? LOOF_TX_CAMPO70 { get; set; }
		public DateTime? LOOF_DT_INICIO { get; set; }
		public DateTime? LOOF_DT_FIM { get; set; }
		public string? LOOF_TX_TEMP_ATEND { get; set; }
		public string? LOOF_TX_TEMP_DISCAGEM { get; set; }
		public string? LOOF_TX_TEMP_LIGACAO { get; set; }
		public long? STDI_CD_ID_FK { get; set; }
		public long? PEIF1_CD_ID_FK { get; set; }
		public long? PEIF2_CD_ID_FK { get; set; }
		public long? PECF1_CD_ID_FK { get; set; }
		public long? PECF2_CD_ID_FK { get; set; }
		public long? PECF3_CD_ID_FK { get; set; }
		public long? PECF4_CD_ID_FK { get; set; }
		public long? PEEF1_CD_ID_FK { get; set; }
		public long? PEEF2_CD_ID_FK { get; set; }
		public long? PEEF3_CD_ID_FK { get; set; }
		public long? PEEF4_CD_ID_FK { get; set; }
		public long? PEEF5_CD_ID_FK { get; set; }
		public long? PEEF6_CD_ID_FK { get; set; }
		public string? LOOF_BB_OCORRENCIA { get; set; }
		public string? LOOF_TX_CAMP_EXT1 { get; set; }
		public string? LOOF_TX_CAMP_EXT2 { get; set; }
		public string? LOOF_TX_CAMP_EXT3 { get; set; }
		public string? LOOF_TX_CAMP_EXT4 { get; set; }
		public string? LOOF_TX_CAMP_EXT5 { get; set; }
		public string? LOOF_TX_CHAVE_IMPORT { get; set; }
		public long? LOOF_NR_ORDEM_DISC { get; set; }
		public string? LOOF_TX_QTD_RET_DISC { get; set; }
		public string? LOOF_TX_STATUS_DISCADOR { get; set; }
		public string? LOOF_TX_ID_DISCADOR { get; set; }
		public string? LOOF_TX_TEL_DISCADOR { get; set; }
		public string? LOOF_TX_CAMPO71 { get; set; }
		public string? LOOF_TX_CAMPO72 { get; set; }
		public string? LOOF_TX_CAMPO73 { get; set; }
		public string? LOOF_TX_CAMPO74 { get; set; }
		public string? LOOF_TX_CAMPO75 { get; set; }
		public string? LOOF_TX_CAMPO76 { get; set; }
		public string? LOOF_TX_CAMPO77 { get; set; }
		public string? LOOF_TX_CAMPO78 { get; set; }
		public string? LOOF_TX_CAMPO79 { get; set; }
		public string? LOOF_TX_CAMPO80 { get; set; }
		public DateTime? LOOF_DT_AGENDAMENTO { get; set; }
		public string? LOOF_TX_DESC_AGEND { get; set; }
		public long? LOOF_NR_TIPO_AGEND { get; set; }
		public long? USUA_AGEND_CD_ID_FK { get; set; }
		public string? LOOF_TX_HOSTNAME { get; set; }
		public long? USUA_AUDIT_CD_ID_FK { get; set; }
		public string? LOOF_TX_RECORD_ID { get; set; }
		public string? LOOF_TX_SERVICE_NAME { get; set; }
		public string? LOOF_TX_STATUS_DISCAGEM { get; set; }
		public string? LOOF_ID_NUMERO_UNICO { get; set; }
		public long? LOOA_CD_ID_FK { get; set; }
		public long? USUA_ANTERIOR_CD_ID_FK { get; set; }
		public string? LOOF_TX_LOGIN_TELEFONIA { get; set; }
		public string? LOOF_TX_TEMP_TOTAL { get; set; }
		public long? LOOA_MAIN_CD_ID_FK { get; set; }
		public string? LOOF_TX_CAMPO81 { get; set; }
		public string? LOOF_TX_CAMPO82 { get; set; }
		public string? LOOF_TX_CAMPO83 { get; set; }
		public string? LOOF_TX_CAMPO84 { get; set; }
		public string? LOOF_TX_CAMPO85 { get; set; }
		public string? LOOF_TX_CAMPO86 { get; set; }
		public string? LOOF_TX_CAMPO87 { get; set; }
		public string? LOOF_TX_CAMPO88 { get; set; }
		public string? LOOF_TX_CAMPO89 { get; set; }
		public string? LOOF_TX_CAMPO90 { get; set; }
		public string? LOOF_TX_CAMPO91 { get; set; }
		public string? LOOF_TX_CAMPO92 { get; set; }
		public string? LOOF_TX_CAMPO93 { get; set; }
		public string? LOOF_TX_CAMPO94 { get; set; }
		public string? LOOF_TX_CAMPO95 { get; set; }
		public string? LOOF_TX_CAMPO96 { get; set; }
		public string? LOOF_TX_CAMPO97 { get; set; }
		public string? LOOF_TX_CAMPO98 { get; set; }
		public string? LOOF_TX_CAMPO99 { get; set; }
		public string? LOOF_TX_CAMPO100 { get; set; }
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.		
	}
}
