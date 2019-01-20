using PoupaguaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PoupaguaDDD.Infra.Data.EntityConfig
{
    public class PredioConfiguration : EntityTypeConfiguration<Predio>
    {
        public PredioConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Nome).IsRequired();

            HasRequired(x => x.EnderecoDoPredio).WithRequiredPrincipal(x => x.Predio);
        }
    }
}
