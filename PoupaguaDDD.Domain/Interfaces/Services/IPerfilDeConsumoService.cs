using PoupaguaDDD.Domain.Entities;
using System.Collections.Generic;

namespace PoupaguaDDD.Domain.Interfaces.Services
{
    public interface IPerfilDeConsumoService : IServiceBase<PerfilDeConsumo>
    {
        double CalcularQuantDeLitrosAcumuladosNoMes(ICollection<Morador> moradoresDoPredio, ICollection<Morador> moradoresDaUC, ICollection<ContaDeAgua> contasPassadasDoPredio);
        double CalculaMediaDiariaDeLitrosUtilizados(ICollection<Morador> moradoresDoPredio, ICollection<Morador> moradoresDaUC, ICollection<ContaDeAgua> contasPassadasDoPredio);

    }
}
