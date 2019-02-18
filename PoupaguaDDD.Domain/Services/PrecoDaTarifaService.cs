using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class PrecoDaTarifaService : IPrecoDaTarifaService
    {
        private readonly IPrecoDaTarifaRepository _precoDaTarifaRepository;

        public PrecoDaTarifaService(IPrecoDaTarifaRepository precoDaTarifaRepository)
        {
            _precoDaTarifaRepository = precoDaTarifaRepository;
        }

        public float CalcularPreco(PrecoDaTarifa precoDaTarifaParaCalculo, int mediaDeLitros)
        {
            return precoDaTarifaParaCalculo.CalcularPreco(precoDaTarifaParaCalculo, mediaDeLitros);
        }

        public void Dispose()
        {
            _precoDaTarifaRepository.Dispose();
        }
    }
}
