using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace PoupaguaDDD.Infra.Data.Context
{
    [DbConfigurationType(typeof(PoupaguaContextConfiguration))]
    public class PoupaguaContext : DbContext
    {
        public PoupaguaContext() : base("Poupagua") { }

        public DbSet<ContaDeAgua> ContasDeAgua { get; set; }
        public DbSet<EnderecoCompleto> EnderecosCompletos { get; set; }
        public DbSet<EnderecoDoPredio> EnderecosDosPredios { get; set; }
        public DbSet<MetaGeral> MetasGerais { get; set; }
        public DbSet<MetaIndividual> MetasIndividuais { get; set; }
        public DbSet<Morador> Moradores { get; set; }
        public DbSet<PerfilDeConsumo> PerfisDeConsumo { get; set; }
        public DbSet<PontoDeConsumo> PontosDeConsumo { get; set; }
        public DbSet<PrecoDaTarifa> PrecosDaTarifa { get; set; }
        public DbSet<Predio> Predios { get; set; }
        public DbSet<Tarifa> Tarifas { get; set; }
        public DbSet<UnidadeConsumidora> UnidadesConsumidoras { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ValorAlertaGeral> ValoresAlertaGeral { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(x => x.Name == "Id").Configure(x => x.IsKey());
            modelBuilder.Properties().Where(x => x.Name == "DataCadastro").Configure(x => x.IsRequired());

            modelBuilder.Properties<string>().Configure(x => x.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(x => x.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ContaDeAguaConfiguration());
            modelBuilder.Configurations.Add(new EnderecoCompletoConfiguration());
            modelBuilder.Configurations.Add(new EnderecoDoPredioConfiguration());
            modelBuilder.Configurations.Add(new MetaGeralConfiguration());
            modelBuilder.Configurations.Add(new MetaIndividualConfiguration());
            modelBuilder.Configurations.Add(new MoradorConfiguration());
            modelBuilder.Configurations.Add(new PerfilDeConsumoConfiguration());
            modelBuilder.Configurations.Add(new PontoDeConsumoConfiguration());
            modelBuilder.Configurations.Add(new PrecoDaTarifaConfiguration());
            modelBuilder.Configurations.Add(new PredioConfiguration());
            modelBuilder.Configurations.Add(new TarifaConfiguration());
            modelBuilder.Configurations.Add(new UnidadeConsumidoraConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new ValorAlertaGeralConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
