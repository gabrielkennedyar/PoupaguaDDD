using PoupaguaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PoupaguaDDD.Infra.Data.EntityConfig
{
    public class MetaIndividualConfiguration : EntityTypeConfiguration<MetaIndividual>
    {
        public MetaIndividualConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.MesAno).IsRequired();
            Property(x => x.QuantidadeDeEconomiaEmM3).IsRequired();

            HasRequired(x => x.UnidadeConsumidora).WithMany(x => x.MetasIndividuais).HasForeignKey(x => x.UnidadeConsumidoraId);
        }
    }
}
