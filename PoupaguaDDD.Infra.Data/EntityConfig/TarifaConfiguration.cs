using PoupaguaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
