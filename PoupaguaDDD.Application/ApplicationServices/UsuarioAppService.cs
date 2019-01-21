using PoupaguaDDD.Application.Interface;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace PoupaguaDDD.Application.ApplicationServices
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService) : base(usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IEnumerable<Usuario> BuscarPorEmail(string email)
        {
            return _usuarioService.BuscarPorEmail(email);
        }
    }
}
