using PoupaguaDDD.Domain.Entities;

namespace PoupaguaDDD.Domain.Interfaces.Services
{
    public interface IPrecoDaTarifaService : IServiceBase<PrecoDaTarifa>
    {
        float CalcularPreco(int mediaDeLitros);
    }
}
