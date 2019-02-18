using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Infra.Data.Context;
using System.Linq;

namespace PoupaguaDDD.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(PoupaguaContext poupaguaContext) : base(poupaguaContext)
        {

        }

        public Usuario BuscarPorEmail(string email)
        {
            return Db.Usuarios.FirstOrDefault(x => x.Email == email);
        }

        public Usuario BuscarPorCpf(string cpf)
        {
            return Db.Usuarios.FirstOrDefault(x => x.CPF == cpf);
        }

        public override void Remover(string id)
        {
            var usuario = ObterPorId(id);
            usuario.DefinirComoExcluido();

            Atualizar(usuario);
        }
    }
}
