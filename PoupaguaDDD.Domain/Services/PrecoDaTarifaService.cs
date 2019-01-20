using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class PrecoDaTarifaService : ServiceBase<PrecoDaTarifa>, IPrecoDaTarifaService
    {
        private readonly IPrecoDaTarifaRepository _precoDaTarifaRepository;

        public PrecoDaTarifaService(IPrecoDaTarifaRepository precoDaTarifaRepository) : base(precoDaTarifaRepository)
        {
            _precoDaTarifaRepository = precoDaTarifaRepository;
        }

        public float CalcularPreco(PrecoDaTarifa precoDaTarifaParaCalculo, int mediaDeLitros)
        {
            return precoDaTarifaParaCalculo.CalcularPreco(precoDaTarifaParaCalculo, mediaDeLitros);
        }
    }
}
