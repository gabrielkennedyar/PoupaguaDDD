using PoupaguaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PoupaguaDDD.Infra.Data.EntityConfig
{
    public class PerfilDeConsumoConfiguration : EntityTypeConfiguration<PerfilDeConsumo>
    {
        public PerfilDeConsumoConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.MediaDeConsumoMensal).IsOptional();

        }
    }
}
