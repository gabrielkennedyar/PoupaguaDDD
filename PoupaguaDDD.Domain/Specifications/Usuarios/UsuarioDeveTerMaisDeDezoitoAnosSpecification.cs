using DomainValidation.Interfaces.Specification;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Value_Objects.Usuarios;

namespace PoupaguaDDD.Domain.Specifications.Usuarios
{
    public class UsuarioDeveTerMaisDeDezoitoAnosSpecification : ISpecification<Usuario>
    {
        public bool IsSatisfiedBy(Usuario usuario)
        {
            return DataNasc.Validar(usuario.DataNasc);
        }
    }
}
