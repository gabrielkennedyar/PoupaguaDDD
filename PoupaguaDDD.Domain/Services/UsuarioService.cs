using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;
using PoupaguaDDD.Domain.Validations.Usuarios;

namespace PoupaguaDDD.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuario Adicionar(Usuario usuario)
        {
            if (!usuario.EhValido()) return usuario;

            usuario.ValidationResult = new UsuarioEstaAptoParaCadastroValidation(_usuarioRepository).Validate(usuario);

            if (usuario.ValidationResult.IsValid) _usuarioRepository.Adicionar(usuario);

            return usuario;
        }

        public Usuario Atualizar(Usuario usuario)
        {
            if (!usuario.EhValido()) return usuario;

            _usuarioRepository.Atualizar(usuario);
            return usuario;
        }

        public void Remover(string id)
        {
            _usuarioRepository.Remover(id);
        }

        public void Dispose()
        {
            _usuarioRepository.Dispose();
        }        
    }
}
