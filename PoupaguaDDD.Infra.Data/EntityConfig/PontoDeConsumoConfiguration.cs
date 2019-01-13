using PoupaguaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoupaguaDDD.Infra.Data.EntityConfig
{
    public class PontoDeConsumoConfiguration : EntityTypeConfiguration<PontoDeConsumo>
    {
        public PontoDeConsumoConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Apto).IsRequired();
            Property(x => x.Nome).IsOptional();

            HasRequired(x => x.Predio).WithMany(x => x.PontosDeConsumo).HasForeignKey(x => x.PredioId);
        }
    }
}
