using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace PoupaguaDDD.Domain.Services
{
    public class PerfilDeConsumoService : ServiceBase<PerfilDeConsumo>, IPerfilDeConsumoService
    {
        private readonly IPerfilDeConsumoRepository _perfilDeConsumoRepository;

        public PerfilDeConsumoService(IPerfilDeConsumoRepository perfilDeConsumoRepository) : base(perfilDeConsumoRepository)
        {
            _perfilDeConsumoRepository = perfilDeConsumoRepository;
        }

        public double CalcularMediaDiariaDeLitrosUtilizados(ICollection<Morador> moradoresDoPredio, ICollection<Morador> moradoresDaUC, ICollection<ContaDeAgua> contasPassadasDoPredio, PerfilDeConsumo perfilDeConsumoDoUsuario)
        {
            return perfilDeConsumoDoUsuario.CalcularMediaDiariaDeLitrosUtilizados(moradoresDoPredio, moradoresDaUC, contasPassadasDoPredio, perfilDeConsumoDoUsuario);
        }

        public double CalcularQuantDeLitrosAcumuladosNoMes(ICollection<Morador> moradoresDoPredio, ICollection<Morador> moradoresDaUC, ICollection<ContaDeAgua> contasPassadasDoPredio, PerfilDeConsumo perfilDeConsumoDoUsuario)
        {
            return perfilDeConsumoDoUsuario.CalcularQuantDeLitrosAcumuladosNoMes(moradoresDoPredio, moradoresDaUC, contasPassadasDoPredio, perfilDeConsumoDoUsuario);
        }
    }
}
