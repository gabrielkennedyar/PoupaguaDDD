using PoupaguaDDD.Application.Interface;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Application.ApplicationServices
{
    public class MetaIndividualAppService : AppServiceBase<MetaIndividual>, IMetaIndividualAppService
    {
        private readonly IMetaIndividualService _metaIndividualService;

        public MetaIndividualAppService(IMetaIndividualService metaIndividualService) : base(metaIndividualService)
        {
            _metaIndividualService = metaIndividualService;
        }

        public double CalcularDiferencaEmM3DaMeta(MetaIndividual ultimaMetaIndividualDaUC, int quantidadeUsadaEmLitros)
        {
            return _metaIndividualService.CalcularDiferencaEmM3DaMeta(ultimaMetaIndividualDaUC, quantidadeUsadaEmLitros);
        }

        public bool VerificarSeUltrapassouEconomia(MetaIndividual ultimaMetaIndividualDaUC, int quantidadeUsadaEmLitros)
        {
            return _metaIndividualService.VerificarSeUltrapassouEconomia(ultimaMetaIndividualDaUC, quantidadeUsadaEmLitros);
        }
    }
}
