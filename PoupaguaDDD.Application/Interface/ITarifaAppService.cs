using PoupaguaDDD.Domain.Entities;

namespace PoupaguaDDD.Application.Interface
{
    public interface ITarifaAppService : IAppServiceBase<Tarifa>
    {
        float CalcularTarifa(Tarifa tarifaParaCalculo, int mediaDeLitros);
    }
}
