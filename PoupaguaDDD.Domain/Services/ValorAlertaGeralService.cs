using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class ValorAlertaGeralService : ServiceBase<ValorAlertaGeral>, IValorAlertaGeralService
    {
        private readonly IValorAlertaGeralRepository _valorAlertaGeralRepository;

        public ValorAlertaGeralService(IValorAlertaGeralRepository valorAlertaGeralRepository) : base(valorAlertaGeralRepository)
        {
            _valorAlertaGeralRepository = valorAlertaGeralRepository;
        }
    }
}
