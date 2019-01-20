using PoupaguaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PoupaguaDDD.Infra.Data.EntityConfig
{
    public class EnderecoDoPredioConfiguration : EntityTypeConfiguration<EnderecoDoPredio>
    {
        public EnderecoDoPredioConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.CEP).IsRequired().HasColumnType("char").HasMaxLength(8);
            Property(x => x.Logradouro).IsRequired().HasMaxLength(250);
            Property(x => x.Numero).IsRequired();
            Property(x => x.Bloco).IsRequired();
            Property(x => x.Bairro).IsRequired();
            Property(x => x.Cidade).IsRequired();
            Property(x => x.Estado).IsRequired().HasColumnType("char").HasMaxLength(2);
            Property(x => x.Pais).IsRequired();
        }
    }
}
