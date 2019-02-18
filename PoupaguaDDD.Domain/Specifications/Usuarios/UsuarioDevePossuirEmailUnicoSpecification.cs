using DomainValidation.Interfaces.Specification;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;

namespace PoupaguaDDD.Domain.Specifications.Usuarios
{
    public class UsuarioDevePossuirEmailUnicoSpecification : ISpecification<Usuario>
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioDevePossuirEmailUnicoSpecification(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public bool IsSatisfiedBy(Usuario usuario)
        {
            return _usuarioRepository.BuscarPorEmail(usuario.Email) == null;
        }
    }
}
