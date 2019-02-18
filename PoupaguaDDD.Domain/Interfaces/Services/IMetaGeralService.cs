using PoupaguaDDD.Domain.Entities;
using System;

namespace PoupaguaDDD.Domain.Interfaces.Services
{
    public interface IMetaGeralService : IDisposable
    {
        bool VerificarSeUltrapassouMetaDeUso(MetaGeral ultimaMetaGeralDoPredio, int quantidadeUsadaEmLitros);
        double CalcularDiferencaEmLitrosDaMeta(MetaGeral ultimaMetaGeralDoPredio, int quantidadeUsadaEmLitros);
    }
}
