using PoupaguaDDD.Domain.Entities;
using System;

namespace PoupaguaDDD.Domain.Interfaces.Services
{
    public interface IMetaIndividualService : IDisposable
    {
        bool VerificarSeUltrapassouEconomia(MetaIndividual ultimaMetaIndividualDaUC, int quantidadeUsadaEmLitros);
        double CalcularDiferencaEmM3DaMeta(MetaIndividual ultimaMetaIndividualDaUC, int quantidadeUsadaEmLitros);
    }
}
