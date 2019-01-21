using PoupaguaDDD.Domain.Entities;

namespace PoupaguaDDD.Application.Interface
{
    public interface IMetaGeralAppService : IAppServiceBase<MetaGeral>
    {
        bool VerificarSeUltrapassouMetaDeUso(MetaGeral ultimaMetaGeralDoPredio, int quantidadeUsadaEmLitros);
        double CalcularDiferencaEmLitrosDaMeta(MetaGeral ultimaMetaGeralDoPredio, int quantidadeUsadaEmLitros);
    }
}
