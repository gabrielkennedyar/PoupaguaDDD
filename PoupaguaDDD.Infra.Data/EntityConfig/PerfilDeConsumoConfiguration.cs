using PoupaguaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
