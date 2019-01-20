using PoupaguaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PoupaguaDDD.Infra.Data.EntityConfig
{
    public class MoradorConfiguration : EntityTypeConfiguration<Morador>
    {
        public MoradorConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Nome).IsRequired();
            Property(x => x.MediaDeHoras).IsRequired();

            HasRequired(x => x.UnidadeConsumidora).WithMany(x => x.Moradores).HasForeignKey(x => x.UnidadeConsumidoraId);
        }
    }
}
