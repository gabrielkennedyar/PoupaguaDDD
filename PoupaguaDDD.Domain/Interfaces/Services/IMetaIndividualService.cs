using PoupaguaDDD.Domain.Entities;

namespace PoupaguaDDD.Domain.Interfaces.Services
{
    public interface IMetaIndividualService : IServiceBase<MetaIndividual>
    {
        bool UltrapassouEconomia(int quantidadeUsadaEmLitros);
        double CalculaDiferencaEmM3DaMeta(int quantidadeUsadaEmLitros);
    }
}
