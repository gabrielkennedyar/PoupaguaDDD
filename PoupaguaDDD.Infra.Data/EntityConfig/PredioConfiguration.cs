using PoupaguaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
