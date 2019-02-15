using PoupaguaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PoupaguaDDD.Infra.Data.EntityConfig
{
    public class UnidadeConsumidoraConfiguration : EntityTypeConfiguration<UnidadeConsumidora>
    {
        public UnidadeConsumidoraConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Apto).IsRequired();

            HasOptional(x => x.Usuario).WithMany(x => x.UnidadeConsumidora).HasForeignKey(x => x.UsuarioId);
            HasOptional(x => x.PerfilDeConsumo).WithRequired(x => x.UnidadeConsumidora);
            HasOptional(x => x.PontoDeConsumo).WithRequired(x => x.UnidadeConsumidora);
        }
    }
}
