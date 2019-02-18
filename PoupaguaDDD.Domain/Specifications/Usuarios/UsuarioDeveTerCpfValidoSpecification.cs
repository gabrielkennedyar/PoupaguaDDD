using DomainValidation.Interfaces.Specification;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Value_Objects.Usuarios;

namespace PoupaguaDDD.Domain.Specifications.Usuarios
{
    public class UsuarioDeveTerCpfValidoSpecification : ISpecification<Usuario>
    {
        public bool IsSatisfiedBy(Usuario usuario)
        {
            return CPF.Validar(usuario.CPF);
        }
    }
}
