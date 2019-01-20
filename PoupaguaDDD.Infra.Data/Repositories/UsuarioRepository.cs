using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace PoupaguaDDD.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public IEnumerable<Usuario> BuscarPorEmail(string email)
        {
            return Db.Usuarios.Where(x => x.Email == email);
        }
    }
}
