using PoupaguaDDD.Domain.Entities;
using System.Collections.Generic;

namespace PoupaguaDDD.Application.Interface
{
    public interface IUsuarioAppService : IAppServiceBase<Usuario>
    {
        IEnumerable<Usuario> BuscarPorEmail(string email);
    }
}
