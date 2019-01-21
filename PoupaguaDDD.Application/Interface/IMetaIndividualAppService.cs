using PoupaguaDDD.Domain.Entities;

namespace PoupaguaDDD.Application.Interface
{
    public interface IMetaIndividualAppService : IAppServiceBase<MetaIndividual>
    {
        bool VerificarSeUltrapassouEconomia(MetaIndividual ultimaMetaIndividualDaUC, int quantidadeUsadaEmLitros);
        double CalcularDiferencaEmM3DaMeta(MetaIndividual ultimaMetaIndividualDaUC, int quantidadeUsadaEmLitros);
    }
}
