using PoupaguaDDD.Domain.Entities;

namespace PoupaguaDDD.Domain.Interfaces.Services
{
    public interface IMetaGeralService : IServiceBase<MetaGeral>
    {
        bool UltrapassouMetaDeUso(int quantidadeUsadaEmLitros);
        double CalculaDiferencaEmLitrosDaMeta(int quantidadeUsadaEmLitros);
    }
}
