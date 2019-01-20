using PoupaguaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

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
