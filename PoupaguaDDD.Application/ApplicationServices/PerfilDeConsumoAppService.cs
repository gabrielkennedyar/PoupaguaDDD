using PoupaguaDDD.Application.Interface;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace PoupaguaDDD.Application.ApplicationServices
{
    public class PerfilDeConsumoAppService : AppServiceBase<PerfilDeConsumo>, IPerfilDeConsumoAppService
    {
        private readonly IPerfilDeConsumoService _perfilDeConsumoService;

        public PerfilDeConsumoAppService(IPerfilDeConsumoService perfilDeConsumoService) : base(perfilDeConsumoService)
        {
            _perfilDeConsumoService = perfilDeConsumoService;
        }

        public double CalcularMediaDiariaDeLitrosUtilizados(ICollection<Morador> moradoresDoPredio, ICollection<Morador> moradoresDaUC, ICollection<ContaDeAgua> contasPassadasDoPredio, PerfilDeConsumo perfilDeConsumoDoUsuario)
        {
            return _perfilDeConsumoService.CalcularMediaDiariaDeLitrosUtilizados(moradoresDoPredio, moradoresDaUC, contasPassadasDoPredio, perfilDeConsumoDoUsuario);
        }

        public double CalcularQuantDeLitrosAcumuladosNoMes(ICollection<Morador> moradoresDoPredio, ICollection<Morador> moradoresDaUC, ICollection<ContaDeAgua> contasPassadasDoPredio, PerfilDeConsumo perfilDeConsumoDoUsuario)
        {
            return _perfilDeConsumoService.CalcularQuantDeLitrosAcumuladosNoMes(moradoresDoPredio, moradoresDaUC, contasPassadasDoPredio, perfilDeConsumoDoUsuario);
        }
    }
}
