using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueChip.Models
{
	public class UsuarioConfiguracoes : IEntityTypeConfiguration<Usuario>
	{
		public void Configure(EntityTypeBuilder<Usuario> builder)
		{
			builder.ToTable("USUARIO");
			builder.Property(p => p.USUA_CD_ID_PK).HasColumnName("USUA_CD_ID_PK");
			builder.Property(p => p.USUA_NM_LOGIN).HasColumnName("USUA_NM_LOGIN");
			builder.Property(p => p.USUA_NM_NOME).HasColumnName("USUA_NM_NOME");
			builder.Property(p => p.USUA_CD_ID_GEST1_FK).HasColumnName("USUA_CD_ID_GEST1_FK");
			builder.Property(p => p.USUA_CD_ID_GEST2_FK).HasColumnName("USUA_CD_ID_GEST2_FK");
			builder.Property(p => p.OPER_CD_ID_FK).HasColumnName("OPER_CD_ID_FK");
			builder.Property(p => p.USUA_TX_CPF).HasColumnName("USUA_TX_CPF");
		}
	}
}