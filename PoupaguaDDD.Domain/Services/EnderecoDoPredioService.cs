using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class EnderecoDoPredioService : IEnderecoDoPredioService
    {
        private readonly IEnderecoDoPredioRepository _enderecoDoPredioRepository;

        public EnderecoDoPredioService(IEnderecoDoPredioRepository enderecoDoPredioRepository)
        {
            _enderecoDoPredioRepository = enderecoDoPredioRepository;
        }

        public void Dispose()
        {
            _enderecoDoPredioRepository.Dispose();
        }
    }
}
