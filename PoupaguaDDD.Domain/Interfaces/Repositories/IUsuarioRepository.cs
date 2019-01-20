using PoupaguaDDD.Domain.Entities;
using System.Collections.Generic;

namespace PoupaguaDDD.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        IEnumerable<Usuario> BuscarPorEmail(string email);
    }
}
