using PoupaguaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
