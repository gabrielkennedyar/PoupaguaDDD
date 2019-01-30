using PoupaguaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PoupaguaDDD.Infra.Data.EntityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Email).IsRequired().HasMaxLength(250);
            Property(x => x.Senha).IsRequired().HasMaxLength(50);
            Property(x => x.Nome).IsRequired().HasMaxLength(150);
            Property(x => x.Telefone).IsOptional().HasMaxLength(12);
            Property(x => x.CPF).IsOptional().HasMaxLength(11).IsFixedLength();
            Property(x => x.DataNasc).IsOptional();
            Property(x => x.Ativo).IsRequired();
            Property(x => x.Gerente).IsRequired();

            HasOptional(x => x.Endereco).WithRequired(x => x.Usuario);
            HasOptional(x => x.UnidadeConsumidora).WithRequired(x => x.Usuario);

            HasIndex(x => x.Email).IsUnique();
            HasIndex(x => x.CPF).IsUnique();
        }
    }
}
