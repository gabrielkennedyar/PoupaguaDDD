using PoupaguaDDD.Domain.Entities;
using System.Collections.Generic;

namespace PoupaguaDDD.Domain.Interfaces.Services
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {
        IEnumerable<Usuario> BuscarPorEmail(string email);
    }
}
