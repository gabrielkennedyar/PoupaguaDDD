using PoupaguaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PoupaguaDDD.Infra.Data.EntityConfig
{
    public class MetaGeralConfiguration : EntityTypeConfiguration<MetaGeral>
    {
        public MetaGeralConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.MesAno).IsRequired();
            Property(x => x.QuantidadeEmLitros).IsRequired();

            HasRequired(x => x.Predio).WithMany(x => x.MetasGerais).HasForeignKey(x => x.PredioId);
        }
    }
}
