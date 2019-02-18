using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class ValorAlertaGeralService : IValorAlertaGeralService
    {
        private readonly IValorAlertaGeralRepository _valorAlertaGeralRepository;

        public ValorAlertaGeralService(IValorAlertaGeralRepository valorAlertaGeralRepository)
        {
            _valorAlertaGeralRepository = valorAlertaGeralRepository;
        }

        public void Dispose()
        {
            _valorAlertaGeralRepository.Dispose();
        }
    }
}
