using PoupaguaDDD.Domain.Entities;

namespace PoupaguaDDD.Domain.Interfaces.Services
{
    public interface ITarifaService : IServiceBase<Tarifa>
    {
        float CalcularTarifa(Tarifa tarifaParaCalculo, int mediaDeLitros);
    }
}
