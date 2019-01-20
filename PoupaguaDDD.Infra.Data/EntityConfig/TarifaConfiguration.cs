using PoupaguaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PoupaguaDDD.Infra.Data.EntityConfig
{
    public class TarifaConfiguration : EntityTypeConfiguration<Tarifa>
    {
        public TarifaConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.MesAnoDeReferencia).IsRequired();
            Property(x => x.PrecoDoEsgoto).IsRequired();

        }
    }
}
