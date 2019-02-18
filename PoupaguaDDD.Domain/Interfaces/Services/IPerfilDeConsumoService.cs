using PoupaguaDDD.Domain.Entities;
using System;
using System.Collections.Generic;

namespace PoupaguaDDD.Domain.Interfaces.Services
{
    public interface IPerfilDeConsumoService : IDisposable
    {
        double CalcularQuantDeLitrosAcumuladosNoMes(ICollection<Morador> moradoresDoPredio, ICollection<Morador> moradoresDaUC, ICollection<ContaDeAgua> contasPassadasDoPredio, PerfilDeConsumo perfilDeConsumoDoUsuario);
        double CalcularMediaDiariaDeLitrosUtilizados(ICollection<Morador> moradoresDoPredio, ICollection<Morador> moradoresDaUC, ICollection<ContaDeAgua> contasPassadasDoPredio, PerfilDeConsumo perfilDeConsumoDoUsuario);

    }
}
