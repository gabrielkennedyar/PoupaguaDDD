using DomainValidation.Validation;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Specifications;
using PoupaguaDDD.Domain.Specifications.Usuarios;

namespace PoupaguaDDD.Domain.Validations.Usuarios
{
    public class UsuarioEstaConsistenteValidation : Validator<Usuario>
    {
        public UsuarioEstaConsistenteValidation()
        {
            //Especificações específicas
            var usuarioCpf = new UsuarioDeveTerCpfValidoSpecification();
            var usuarioDataNasc = new UsuarioDeveTerMaisDeDezoitoAnosSpecification();
            var usuarioEmail = new UsuarioDeveTerEmailValidoSpecification();

            //Especificações genéricas
            var usuarioNome = new GenericSpecification<Usuario>(u => u.Nome.Length >= 2);
            var UsuarioAtivo = new GenericSpecification<Usuario>(u => u.Ativo && !u.Excluido);

            //Adicionar as regras
            Add("usuarioCpf", new Rule<Usuario>(usuarioCpf, "Usuario informou um CPF inválido."));
            Add("usuarioDataNasc", new Rule<Usuario>(usuarioDataNasc, "Usuario deve ter mais de 18 anos."));
            Add("usuarioEmail", new Rule<Usuario>(usuarioEmail, "Usuario deve ter um e-mail válido."));
            Add("usuarioNome", new Rule<Usuario>(usuarioNome, "Nome do usuário deve ter 2 ou mais caracteres"));
            Add("usuarioSenha", new Rule<Usuario>(UsuarioAtivo, "Usuário deve estar ativo"));
        }
    }
}
