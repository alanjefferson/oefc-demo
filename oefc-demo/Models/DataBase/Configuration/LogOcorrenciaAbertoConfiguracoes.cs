using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueChip.Models
{
	public class LogOcorrenciaAbertoConfiguracoes : IEntityTypeConfiguration<LogOcorrenciaAberto>
	{
		public void Configure(EntityTypeBuilder<LogOcorrenciaAberto> builder)
		{
			builder.ToTable("LOG_OCORRENCIA_ABERTO");
			builder.Property(p => p.LOOA_CD_ID_PK).HasColumnName("LOOA_CD_ID_PK");
			builder.Property(p => p.PROD_CD_ID_FK).HasColumnName("PROD_CD_ID_FK");
			builder.Property(p => p.PROJ_CD_ID_FK).HasColumnName("PROJ_CD_ID_FK");
			builder.Property(p => p.CAMP_CD_ID_FK).HasColumnName("CAMP_CD_ID_FK");
			builder.Property(p => p.CAVA_CD_ID_FK).HasColumnName("CAVA_CD_ID_FK");
			builder.Property(p => p.ESTR_CD_ID_FK).HasColumnName("ESTR_CD_ID_FK");
			builder.Property(p => p.USUA_CD_ID_FK).HasColumnName("USUA_CD_ID_FK");
			builder.Property(p => p.USUA_GEST1_CD_ID_FK).HasColumnName("USUA_GEST1_CD_ID_FK");
			builder.Property(p => p.USUA_GEST2_CD_ID_FK).HasColumnName("USUA_GEST2_CD_ID_FK");
			builder.Property(p => p.LOOA_DT_CADASTRO).HasColumnName("LOOA_DT_CADASTRO");
			builder.Property(p => p.LOOA_TX_STATUS).HasColumnName("LOOA_TX_STATUS");
			builder.Property(p => p.LOOA_TX_STATUS_ANTERIOR).HasColumnName("LOOA_TX_STATUS_ANTERIOR");
			builder.Property(p => p.LOOA_TX_CAMPO_CHAVE).HasColumnName("LOOA_TX_CAMPO_CHAVE");
			builder.Property(p => p.LOOA_TX_CAMPO1).HasColumnName("LOOA_TX_CAMPO1");
			builder.Property(p => p.LOOA_TX_CAMPO2).HasColumnName("LOOA_TX_CAMPO2");
			builder.Property(p => p.LOOA_TX_CAMPO3).HasColumnName("LOOA_TX_CAMPO3");
			builder.Property(p => p.LOOA_TX_CAMPO4).HasColumnName("LOOA_TX_CAMPO4");
			builder.Property(p => p.LOOA_TX_CAMPO5).HasColumnName("LOOA_TX_CAMPO5");
			builder.Property(p => p.LOOA_TX_CAMPO6).HasColumnName("LOOA_TX_CAMPO6");
			builder.Property(p => p.LOOA_TX_CAMPO7).HasColumnName("LOOA_TX_CAMPO7");
			builder.Property(p => p.LOOA_TX_CAMPO8).HasColumnName("LOOA_TX_CAMPO8");
			builder.Property(p => p.LOOA_TX_CAMPO9).HasColumnName("LOOA_TX_CAMPO9");
			builder.Property(p => p.LOOA_TX_CAMPO10).HasColumnName("LOOA_TX_CAMPO10");
			builder.Property(p => p.LOOA_TX_CAMPO11).HasColumnName("LOOA_TX_CAMPO11");
			builder.Property(p => p.LOOA_TX_CAMPO12).HasColumnName("LOOA_TX_CAMPO12");
			builder.Property(p => p.LOOA_TX_CAMPO13).HasColumnName("LOOA_TX_CAMPO13");
			builder.Property(p => p.LOOA_TX_CAMPO14).HasColumnName("LOOA_TX_CAMPO14");
			builder.Property(p => p.LOOA_TX_CAMPO15).HasColumnName("LOOA_TX_CAMPO15");
			builder.Property(p => p.LOOA_TX_CAMPO16).HasColumnName("LOOA_TX_CAMPO16");
			builder.Property(p => p.LOOA_TX_CAMPO17).HasColumnName("LOOA_TX_CAMPO17");
			builder.Property(p => p.LOOA_TX_CAMPO18).HasColumnName("LOOA_TX_CAMPO18");
			builder.Property(p => p.LOOA_TX_CAMPO19).HasColumnName("LOOA_TX_CAMPO19");
			builder.Property(p => p.LOOA_TX_CAMPO20).HasColumnName("LOOA_TX_CAMPO20");
			builder.Property(p => p.LOOA_TX_CAMPO21).HasColumnName("LOOA_TX_CAMPO21");
			builder.Property(p => p.LOOA_TX_CAMPO22).HasColumnName("LOOA_TX_CAMPO22");
			builder.Property(p => p.LOOA_TX_CAMPO23).HasColumnName("LOOA_TX_CAMPO23");
			builder.Property(p => p.LOOA_TX_CAMPO24).HasColumnName("LOOA_TX_CAMPO24");
			builder.Property(p => p.LOOA_TX_CAMPO25).HasColumnName("LOOA_TX_CAMPO25");
			builder.Property(p => p.LOOA_TX_CAMPO26).HasColumnName("LOOA_TX_CAMPO26");
			builder.Property(p => p.LOOA_TX_CAMPO27).HasColumnName("LOOA_TX_CAMPO27");
			builder.Property(p => p.LOOA_TX_CAMPO28).HasColumnName("LOOA_TX_CAMPO28");
			builder.Property(p => p.LOOA_TX_CAMPO29).HasColumnName("LOOA_TX_CAMPO29");
			builder.Property(p => p.LOOA_TX_CAMPO30).HasColumnName("LOOA_TX_CAMPO30");
			builder.Property(p => p.LOOA_TX_CAMPO31).HasColumnName("LOOA_TX_CAMPO31");
			builder.Property(p => p.LOOA_TX_CAMPO32).HasColumnName("LOOA_TX_CAMPO32");
			builder.Property(p => p.LOOA_TX_CAMPO33).HasColumnName("LOOA_TX_CAMPO33");
			builder.Property(p => p.LOOA_TX_CAMPO34).HasColumnName("LOOA_TX_CAMPO34");
			builder.Property(p => p.LOOA_TX_CAMPO35).HasColumnName("LOOA_TX_CAMPO35");
			builder.Property(p => p.LOOA_TX_CAMPO36).HasColumnName("LOOA_TX_CAMPO36");
			builder.Property(p => p.LOOA_TX_CAMPO37).HasColumnName("LOOA_TX_CAMPO37");
			builder.Property(p => p.LOOA_TX_CAMPO38).HasColumnName("LOOA_TX_CAMPO38");
			builder.Property(p => p.LOOA_TX_CAMPO39).HasColumnName("LOOA_TX_CAMPO39");
			builder.Property(p => p.LOOA_TX_CAMPO40).HasColumnName("LOOA_TX_CAMPO40");
			builder.Property(p => p.LOOA_TX_CAMPO41).HasColumnName("LOOA_TX_CAMPO41");
			builder.Property(p => p.LOOA_TX_CAMPO42).HasColumnName("LOOA_TX_CAMPO42");
			builder.Property(p => p.LOOA_TX_CAMPO43).HasColumnName("LOOA_TX_CAMPO43");
			builder.Property(p => p.LOOA_TX_CAMPO44).HasColumnName("LOOA_TX_CAMPO44");
			builder.Property(p => p.LOOA_TX_CAMPO45).HasColumnName("LOOA_TX_CAMPO45");
			builder.Property(p => p.LOOA_TX_CAMPO46).HasColumnName("LOOA_TX_CAMPO46");
			builder.Property(p => p.LOOA_TX_CAMPO47).HasColumnName("LOOA_TX_CAMPO47");
			builder.Property(p => p.LOOA_TX_CAMPO48).HasColumnName("LOOA_TX_CAMPO48");
			builder.Property(p => p.LOOA_TX_CAMPO49).HasColumnName("LOOA_TX_CAMPO49");
			builder.Property(p => p.LOOA_TX_CAMPO50).HasColumnName("LOOA_TX_CAMPO50");
			builder.Property(p => p.LOOA_TX_CAMPO51).HasColumnName("LOOA_TX_CAMPO51");
			builder.Property(p => p.LOOA_TX_CAMPO52).HasColumnName("LOOA_TX_CAMPO52");
			builder.Property(p => p.LOOA_TX_CAMPO53).HasColumnName("LOOA_TX_CAMPO53");
			builder.Property(p => p.LOOA_TX_CAMPO54).HasColumnName("LOOA_TX_CAMPO54");
			builder.Property(p => p.LOOA_TX_CAMPO55).HasColumnName("LOOA_TX_CAMPO55");
			builder.Property(p => p.LOOA_TX_CAMPO56).HasColumnName("LOOA_TX_CAMPO56");
			builder.Property(p => p.LOOA_TX_CAMPO57).HasColumnName("LOOA_TX_CAMPO57");
			builder.Property(p => p.LOOA_TX_CAMPO58).HasColumnName("LOOA_TX_CAMPO58");
			builder.Property(p => p.LOOA_TX_CAMPO59).HasColumnName("LOOA_TX_CAMPO59");
			builder.Property(p => p.LOOA_TX_CAMPO60).HasColumnName("LOOA_TX_CAMPO60");
			builder.Property(p => p.LOOA_TX_CAMPO61).HasColumnName("LOOA_TX_CAMPO61");
			builder.Property(p => p.LOOA_TX_CAMPO62).HasColumnName("LOOA_TX_CAMPO62");
			builder.Property(p => p.LOOA_TX_CAMPO63).HasColumnName("LOOA_TX_CAMPO63");
			builder.Property(p => p.LOOA_TX_CAMPO64).HasColumnName("LOOA_TX_CAMPO64");
			builder.Property(p => p.LOOA_TX_CAMPO65).HasColumnName("LOOA_TX_CAMPO65");
			builder.Property(p => p.LOOA_TX_CAMPO66).HasColumnName("LOOA_TX_CAMPO66");
			builder.Property(p => p.LOOA_TX_CAMPO67).HasColumnName("LOOA_TX_CAMPO67");
			builder.Property(p => p.LOOA_TX_CAMPO68).HasColumnName("LOOA_TX_CAMPO68");
			builder.Property(p => p.LOOA_TX_CAMPO69).HasColumnName("LOOA_TX_CAMPO69");
			builder.Property(p => p.LOOA_TX_CAMPO70).HasColumnName("LOOA_TX_CAMPO70");
			builder.Property(p => p.LOOA_DT_INICIO).HasColumnName("LOOA_DT_INICIO");
			builder.Property(p => p.LOOA_DT_FIM).HasColumnName("LOOA_DT_FIM");
			builder.Property(p => p.LOOA_TX_TEMP_ATEND).HasColumnName("LOOA_TX_TEMP_ATEND");
			builder.Property(p => p.LOOA_TX_TEMP_DISCAGEM).HasColumnName("LOOA_TX_TEMP_DISCAGEM");
			builder.Property(p => p.LOOA_TX_TEMP_LIGACAO).HasColumnName("LOOA_TX_TEMP_LIGACAO");
			builder.Property(p => p.LOOA_DT_AGENDAMENTO).HasColumnName("LOOA_DT_AGENDAMENTO");
			builder.Property(p => p.LOOA_TX_DESC_AGEND).HasColumnName("LOOA_TX_DESC_AGEND");
			builder.Property(p => p.LOOA_NR_TIPO_AGEND).HasColumnName("LOOA_NR_TIPO_AGEND");
			builder.Property(p => p.USUA_AGEND_CD_ID_FK).HasColumnName("USUA_AGEND_CD_ID_FK");
			builder.Property(p => p.STDI_CD_ID_FK).HasColumnName("STDI_CD_ID_FK");
			builder.Property(p => p.PEIF1_CD_ID_FK).HasColumnName("PEIF1_CD_ID_FK");
			builder.Property(p => p.PEIF2_CD_ID_FK).HasColumnName("PEIF2_CD_ID_FK");
			builder.Property(p => p.PECF1_CD_ID_FK).HasColumnName("PECF1_CD_ID_FK");
			builder.Property(p => p.PECF2_CD_ID_FK).HasColumnName("PECF2_CD_ID_FK");
			builder.Property(p => p.PECF3_CD_ID_FK).HasColumnName("PECF3_CD_ID_FK");
			builder.Property(p => p.PECF4_CD_ID_FK).HasColumnName("PECF4_CD_ID_FK");
			builder.Property(p => p.PEEF1_CD_ID_FK).HasColumnName("PEEF1_CD_ID_FK");
			builder.Property(p => p.PEEF2_CD_ID_FK).HasColumnName("PEEF2_CD_ID_FK");
			builder.Property(p => p.PEEF3_CD_ID_FK).HasColumnName("PEEF3_CD_ID_FK");
			builder.Property(p => p.PEEF4_CD_ID_FK).HasColumnName("PEEF4_CD_ID_FK");
			builder.Property(p => p.PEEF5_CD_ID_FK).HasColumnName("PEEF5_CD_ID_FK");
			builder.Property(p => p.PEEF6_CD_ID_FK).HasColumnName("PEEF6_CD_ID_FK");
			builder.Property(p => p.LOOA_BB_OCORRENCIA).HasColumnName("LOOA_BB_OCORRENCIA");
			builder.Property(p => p.LOOA_TX_CAMP_EXT1).HasColumnName("LOOA_TX_CAMP_EXT1");
			builder.Property(p => p.LOOA_TX_CAMP_EXT2).HasColumnName("LOOA_TX_CAMP_EXT2");
			builder.Property(p => p.LOOA_TX_CAMP_EXT3).HasColumnName("LOOA_TX_CAMP_EXT3");
			builder.Property(p => p.LOOA_TX_CAMP_EXT4).HasColumnName("LOOA_TX_CAMP_EXT4");
			builder.Property(p => p.LOOA_TX_CAMP_EXT5).HasColumnName("LOOA_TX_CAMP_EXT5");
			builder.Property(p => p.LOOA_TX_CHAVE_IMPORT).HasColumnName("LOOA_TX_CHAVE_IMPORT");
			builder.Property(p => p.LOOA_NR_ORDEM_DISC).HasColumnName("LOOA_NR_ORDEM_DISC");
			builder.Property(p => p.LOOA_TX_QTD_RET_DISC).HasColumnName("LOOA_TX_QTD_RET_DISC");
			builder.Property(p => p.LOOA_TX_STATUS_DISCADOR).HasColumnName("LOOA_TX_STATUS_DISCADOR");
			builder.Property(p => p.LOOA_TX_ID_DISCADOR).HasColumnName("LOOA_TX_ID_DISCADOR");
			builder.Property(p => p.LOOA_TX_TEL_DISCADOR).HasColumnName("LOOA_TX_TEL_DISCADOR");
			builder.Property(p => p.LOOA_TX_TEL_AGEND).HasColumnName("LOOA_TX_TEL_AGEND");
			builder.Property(p => p.LOOA_TX_CAMPO71).HasColumnName("LOOA_TX_CAMPO71");
			builder.Property(p => p.LOOA_TX_CAMPO72).HasColumnName("LOOA_TX_CAMPO72");
			builder.Property(p => p.LOOA_TX_CAMPO73).HasColumnName("LOOA_TX_CAMPO73");
			builder.Property(p => p.LOOA_TX_CAMPO74).HasColumnName("LOOA_TX_CAMPO74");
			builder.Property(p => p.LOOA_TX_CAMPO75).HasColumnName("LOOA_TX_CAMPO75");
			builder.Property(p => p.LOOA_TX_CAMPO76).HasColumnName("LOOA_TX_CAMPO76");
			builder.Property(p => p.LOOA_TX_CAMPO77).HasColumnName("LOOA_TX_CAMPO77");
			builder.Property(p => p.LOOA_TX_CAMPO78).HasColumnName("LOOA_TX_CAMPO78");
			builder.Property(p => p.LOOA_TX_CAMPO79).HasColumnName("LOOA_TX_CAMPO79");
			builder.Property(p => p.LOOA_TX_CAMPO80).HasColumnName("LOOA_TX_CAMPO80");
			builder.Property(p => p.LOOA_TX_HOSTNAME).HasColumnName("LOOA_TX_HOSTNAME");
			builder.Property(p => p.USUA_AUDIT_CD_ID_FK).HasColumnName("USUA_AUDIT_CD_ID_FK");
			builder.Property(p => p.LOOA_TX_RECORD_ID).HasColumnName("LOOA_TX_RECORD_ID");
			builder.Property(p => p.LOOA_TX_SERVICE_NAME).HasColumnName("LOOA_TX_SERVICE_NAME");
			builder.Property(p => p.LOOA_TX_STATUS_DISCAGEM).HasColumnName("LOOA_TX_STATUS_DISCAGEM");
			builder.Property(p => p.LOOA_ID_NUMERO_UNICO).HasColumnName("LOOA_ID_NUMERO_UNICO");
			builder.Property(p => p.LOOA_DT_RETORNO).HasColumnName("LOOA_DT_RETORNO");
			builder.Property(p => p.USUA_ANTERIOR_CD_ID_FK).HasColumnName("USUA_ANTERIOR_CD_ID_FK");
			builder.Property(p => p.LOOA_MAIN_CD_ID_FK).HasColumnName("LOOA_MAIN_CD_ID_FK");
			builder.Property(p => p.LOOA_TX_CAMPO81).HasColumnName("LOOA_TX_CAMPO81");
			builder.Property(p => p.LOOA_TX_CAMPO82).HasColumnName("LOOA_TX_CAMPO82");
			builder.Property(p => p.LOOA_TX_CAMPO83).HasColumnName("LOOA_TX_CAMPO83");
			builder.Property(p => p.LOOA_TX_CAMPO84).HasColumnName("LOOA_TX_CAMPO84");
			builder.Property(p => p.LOOA_TX_CAMPO85).HasColumnName("LOOA_TX_CAMPO85");
			builder.Property(p => p.LOOA_TX_CAMPO86).HasColumnName("LOOA_TX_CAMPO86");
			builder.Property(p => p.LOOA_TX_CAMPO87).HasColumnName("LOOA_TX_CAMPO87");
			builder.Property(p => p.LOOA_TX_CAMPO88).HasColumnName("LOOA_TX_CAMPO88");
			builder.Property(p => p.LOOA_TX_CAMPO89).HasColumnName("LOOA_TX_CAMPO89");
			builder.Property(p => p.LOOA_TX_CAMPO90).HasColumnName("LOOA_TX_CAMPO90");
			builder.Property(p => p.LOOA_TX_CAMPO91).HasColumnName("LOOA_TX_CAMPO91");
			builder.Property(p => p.LOOA_TX_CAMPO92).HasColumnName("LOOA_TX_CAMPO92");
			builder.Property(p => p.LOOA_TX_CAMPO93).HasColumnName("LOOA_TX_CAMPO93");
			builder.Property(p => p.LOOA_TX_CAMPO94).HasColumnName("LOOA_TX_CAMPO94");
			builder.Property(p => p.LOOA_TX_CAMPO95).HasColumnName("LOOA_TX_CAMPO95");
			builder.Property(p => p.LOOA_TX_CAMPO96).HasColumnName("LOOA_TX_CAMPO96");
			builder.Property(p => p.LOOA_TX_CAMPO97).HasColumnName("LOOA_TX_CAMPO97");
			builder.Property(p => p.LOOA_TX_CAMPO98).HasColumnName("LOOA_TX_CAMPO98");
			builder.Property(p => p.LOOA_TX_CAMPO99).HasColumnName("LOOA_TX_CAMPO99");
			builder.Property(p => p.LOOA_TX_CAMPO100).HasColumnName("LOOA_TX_CAMPO100");
		}
	}
}
