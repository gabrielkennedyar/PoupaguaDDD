using PoupaguaDDD.Domain.Entities;
using System.Collections.Generic;

namespace PoupaguaDDD.Application.Interface
{
    public interface IPerfilDeConsumoAppService : IAppServiceBase<PerfilDeConsumo>
    {
        double CalcularQuantDeLitrosAcumuladosNoMes(ICollection<Morador> moradoresDoPredio, ICollection<Morador> moradoresDaUC, ICollection<ContaDeAgua> contasPassadasDoPredio, PerfilDeConsumo perfilDeConsumoDoUsuario);
        double CalcularMediaDiariaDeLitrosUtilizados(ICollection<Morador> moradoresDoPredio, ICollection<Morador> moradoresDaUC, ICollection<ContaDeAgua> contasPassadasDoPredio, PerfilDeConsumo perfilDeConsumoDoUsuario);
    }
}
