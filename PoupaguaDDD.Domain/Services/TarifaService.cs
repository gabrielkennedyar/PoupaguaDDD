using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class TarifaService : ITarifaService
    {
        private readonly ITarifaRepository _tarifaRepository;

        public TarifaService(ITarifaRepository tarifaRepository)
        {
            _tarifaRepository = tarifaRepository;
        }

        public float CalcularTarifa(Tarifa tarifaParaCalculo, int mediaDeLitros)
        {
            return tarifaParaCalculo.CalcularTarifa(tarifaParaCalculo, mediaDeLitros);
        }

        public void Dispose()
        {
            _tarifaRepository.Dispose();
        }
    }
}
