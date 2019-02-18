using DomainValidation.Validation;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Specifications.Usuarios;

namespace PoupaguaDDD.Domain.Validations.Usuarios
{
    public class UsuarioEstaAptoParaCadastroValidation : Validator<Usuario>
    {
        public UsuarioEstaAptoParaCadastroValidation(IUsuarioRepository usuarioRepository)
        {
            var usuarioUnicoCpf = new UsuarioDevePossuirCpfUnicoSpecification(usuarioRepository);
            var usuarioUnicoEmail = new UsuarioDevePossuirEmailUnicoSpecification(usuarioRepository);

            base.Add("usuarioUnicoCpf", new Rule<Usuario>(usuarioUnicoCpf, "Já existe um usuario com este CPF"));
            base.Add("usuarioUnicoEmail", new Rule<Usuario>(usuarioUnicoEmail, "Já existe um usuario com este Email"));
        }
    }
}
