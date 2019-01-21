using PoupaguaDDD.Application.Interface;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Application.ApplicationServices
{
    public class MetaGeralAppService : AppServiceBase<MetaGeral>, IMetaGeralAppService
    {
        private readonly IMetaGeralService _metaGeralService;

        public MetaGeralAppService(IMetaGeralService metaGeralService) : base(metaGeralService)
        {
            _metaGeralService = metaGeralService;
        }

        public double CalcularDiferencaEmLitrosDaMeta(MetaGeral ultimaMetaGeralDoPredio, int quantidadeUsadaEmLitros)
        {
            return _metaGeralService.CalcularDiferencaEmLitrosDaMeta(ultimaMetaGeralDoPredio, quantidadeUsadaEmLitros);
        }

        public bool VerificarSeUltrapassouMetaDeUso(MetaGeral ultimaMetaGeralDoPredio, int quantidadeUsadaEmLitros)
        {
            return _metaGeralService.VerificarSeUltrapassouMetaDeUso(ultimaMetaGeralDoPredio, quantidadeUsadaEmLitros);
        }
    }
}
