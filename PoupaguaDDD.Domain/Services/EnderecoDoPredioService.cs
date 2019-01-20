using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class EnderecoDoPredioService : ServiceBase<EnderecoDoPredio>, IEnderecoDoPredioService
    {
        private readonly IEnderecoDoPredioRepository _enderecoDoPredioRepository;

        public EnderecoDoPredioService(IEnderecoDoPredioRepository enderecoDoPredioRepository) : base(enderecoDoPredioRepository)
        {
            _enderecoDoPredioRepository = enderecoDoPredioRepository;
        }
    }
}
