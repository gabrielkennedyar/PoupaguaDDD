using PoupaguaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PoupaguaDDD.Infra.Data.EntityConfig
{
    public class ValorAlertaGeralConfiguration : EntityTypeConfiguration<ValorAlertaGeral>
    {
        public ValorAlertaGeralConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.MesAno).IsRequired();
            Property(x => x.QuantidadeEmLitros).IsRequired();

            HasRequired(x => x.Predio).WithMany(x => x.ValoresAlertaGeral).HasForeignKey(x => x.PredioId);
        }
    }
}
