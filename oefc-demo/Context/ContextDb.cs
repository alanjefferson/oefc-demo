using BlueChip.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueChip.Context
{
	public class ContextDb : DbContext
	{
		public DbSet<Usuario> Usuario { get; set; }
		public DbSet<LogOcorrenciaAberto> LogOcorrenciaAberto { get; set; }
		public DbSet<LogOcorrenciaFechado> LogOcorrenciaFechado { get; set; }
		public DbSet<LogIntegracaoServico> LogIntegracaoServico { get; set; }

		public ContextDb(DbContextOptions<ContextDb> options) : base (options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UsuarioConfiguracoes());
			modelBuilder.ApplyConfiguration(new LogOcorrenciaAbertoConfiguracoes());
			modelBuilder.ApplyConfiguration(new LogOcorrenciaFechadoConfiguracoes());
			modelBuilder.ApplyConfiguration(new LogIntegracaoServicoConfiguracoes());
		}
	}
}