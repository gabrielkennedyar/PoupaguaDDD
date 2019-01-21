using PoupaguaDDD.Application.Interface;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Application.ApplicationServices
{
    public class ValorAlertaGeralAppService : AppServiceBase<ValorAlertaGeral>, IValorAlertaGeralAppService
    {
        private readonly IValorAlertaGeralService _valorAlertaGeralService;

        public ValorAlertaGeralAppService(IValorAlertaGeralService valorAlertaGeralService) : base(valorAlertaGeralService)
        {
            _valorAlertaGeralService = valorAlertaGeralService;
        }
    }
}
