using PoupaguaDDD.Domain.Entities;

namespace PoupaguaDDD.Application.Interface
{
    public interface IPrecoDaTarifaAppService : IAppServiceBase<PrecoDaTarifa>
    {
        float CalcularPreco(PrecoDaTarifa precoDaTarifaParaCalculo, int mediaDeLitros);
    }
}
