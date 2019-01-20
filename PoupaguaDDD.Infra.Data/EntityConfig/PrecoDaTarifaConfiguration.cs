using PoupaguaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PoupaguaDDD.Infra.Data.EntityConfig
{
    public class PrecoDaTarifaConfiguration : EntityTypeConfiguration<PrecoDaTarifa>
    {
        public PrecoDaTarifaConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Nivel).IsRequired();
            Property(x => x.PrecoMilLitros).IsRequired();

            HasRequired(x => x.Tarifa).WithMany(x => x.PrecosDasTarifas).HasForeignKey(x => x.TarifaId);
        }
    }
}
