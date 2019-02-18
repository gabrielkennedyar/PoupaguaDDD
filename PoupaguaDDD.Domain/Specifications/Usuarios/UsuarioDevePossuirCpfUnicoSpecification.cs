using DomainValidation.Interfaces.Specification;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;

namespace PoupaguaDDD.Domain.Specifications.Usuarios
{
    public class UsuarioDevePossuirCpfUnicoSpecification : ISpecification<Usuario>
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioDevePossuirCpfUnicoSpecification(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public bool IsSatisfiedBy(Usuario usuario)
        {
            return _usuarioRepository.BuscarPorCpf(usuario.CPF) == null;
        }
    }
}
