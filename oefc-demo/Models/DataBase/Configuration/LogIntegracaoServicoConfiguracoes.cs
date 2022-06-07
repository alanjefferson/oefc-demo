using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueChip.Models
{
	public class LogIntegracaoServicoConfiguracoes : IEntityTypeConfiguration<LogIntegracaoServico>
	{
		public void Configure(EntityTypeBuilder<LogIntegracaoServico> builder)
		{
			builder.ToTable("LOG_INTEGRACAO_SERVICO");
			builder.Property(p => p.LOIS_CD_ID_PK).HasColumnName("LOIS_CD_ID_PK");
			builder.Property(p => p.LOIS_DT_EXECUCAO).HasColumnName("LOIS_DT_EXECUCAO");
			builder.Property(p => p.LOIS_TX_SOLICITACAO).HasColumnName("LOIS_TX_SOLICITACAO");
			builder.Property(p => p.LOIS_TX_RETORNO).HasColumnName("LOIS_TX_RETORNO");
			builder.Property(p => p.TIIS_CD_ID_FK).HasColumnName("TIIS_CD_ID_FK");
			builder.Property(p => p.LOOF_CD_ID_FK).HasColumnName("LOOF_CD_ID_FK");
		}
	}
}
