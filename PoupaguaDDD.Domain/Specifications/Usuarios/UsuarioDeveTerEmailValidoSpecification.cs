using DomainValidation.Interfaces.Specification;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Value_Objects.Usuarios;

namespace PoupaguaDDD.Domain.Specifications.Usuarios
{
    public class UsuarioDeveTerEmailValidoSpecification : ISpecification<Usuario>
    {
        public bool IsSatisfiedBy(Usuario usuario)
        {
            return Email.Validar(usuario.Email);
        }
    }
}
