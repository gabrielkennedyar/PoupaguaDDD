using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class MetaIndividualService : IMetaIndividualService
    {
        private readonly IMetaIndividualRepository _metaIndividualRepository;

        public MetaIndividualService(IMetaIndividualRepository metaIndividualRepository)
        {
            _metaIndividualRepository = metaIndividualRepository;
        }

        public double CalcularDiferencaEmM3DaMeta(MetaIndividual ultimaMetaIndividualDaUC, int quantidadeUsadaEmLitros)
        {
            return ultimaMetaIndividualDaUC.CalcularDiferencaEmM3DaMeta(ultimaMetaIndividualDaUC, quantidadeUsadaEmLitros);
        }

        public bool VerificarSeUltrapassouEconomia(MetaIndividual ultimaMetaIndividualDaUC, int quantidadeUsadaEmLitros)
        {
            return ultimaMetaIndividualDaUC.VerificarSeUltrapassouEconomia(ultimaMetaIndividualDaUC, quantidadeUsadaEmLitros);
        }

        public void Dispose()
        {
            _metaIndividualRepository.Dispose();
        }
    }
}
