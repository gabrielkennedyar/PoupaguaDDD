using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class TarifaService : ServiceBase<Tarifa>, ITarifaService
    {
        private readonly ITarifaRepository _tarifaRepository;

        public TarifaService(ITarifaRepository tarifaRepository) : base(tarifaRepository)
        {
            _tarifaRepository = tarifaRepository;
        }

        public float CalcularTarifa(Tarifa tarifaParaCalculo, int mediaDeLitros)
        {
            return tarifaParaCalculo.CalcularTarifa(tarifaParaCalculo, mediaDeLitros);
        }
    }
}
