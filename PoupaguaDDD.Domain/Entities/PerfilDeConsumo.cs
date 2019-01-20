using System;
using System.Collections.Generic;
using System.Linq;

namespace PoupaguaDDD.Domain.Entities
{
    public class PerfilDeConsumo
    {
        public int Id { get; set; }
        public double MediaDeConsumoMensal { get; private set; }
        public DateTime DataCadastro { get; set; }

        public virtual UnidadeConsumidora UnidadeConsumidora { get; set; }

        /// <summary>
        /// Calcula os litros utilizados até o dia atual do mes de uma unidade consumidora
        /// </summary>
        /// <param name="moradoresDoPredio"></param>
        /// <param name="moradoresDaUC"></param>
        /// <param name="contasPassadasDoPredio"></param>
        /// <returns></returns>
        public double CalcularQuantDeLitrosAcumuladosNoMes(ICollection<Morador> moradoresDoPredio, ICollection<Morador> moradoresDaUC, ICollection<ContaDeAgua> contasPassadasDoPredio)
        {
            int diaAtual = DateTime.Today.Day;
            double consumoDiario = CalculaMediaDiariaDeLitrosUtilizados(moradoresDoPredio, moradoresDaUC, contasPassadasDoPredio);
            double consumoAcumulado = consumoDiario * diaAtual;
            return consumoAcumulado;
        }

        /// <summary>
        /// Retorna os litros consumidos diariamente por uma unidade consumidora
        /// </summary>
        /// <param name="moradoresDoPredio"></param>
        /// <param name="moradoresDaUC"></param>
        /// <param name="contasPassadasDoPredio"></param>
        /// <returns></returns>
        public double CalculaMediaDiariaDeLitrosUtilizados(ICollection<Morador> moradoresDoPredio, ICollection<Morador> moradoresDaUC, ICollection<ContaDeAgua> contasPassadasDoPredio)
        {
            double mediaMensal = AtribuirMediaDeConsumoMensalDaUC(moradoresDoPredio, moradoresDaUC, contasPassadasDoPredio);
            int diasDoMesAtual = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
            double consumoDiario = (mediaMensal / diasDoMesAtual);
            return consumoDiario;
        }

        /// <summary>
        /// Retorna a média de consumo da unidade consumidora desta instância de perfil de consumo baseado na litragem total e porcentagem dos moradors da UC
        /// </summary>
        /// <param name="moradoresDoPredio"></param>
        /// <param name="moradoresDaUC"></param>
        /// <param name="contasPassadasDoPredio"></param>
        /// <returns></returns>
        private double AtribuirMediaDeConsumoMensalDaUC(ICollection<Morador> moradoresDoPredio, ICollection<Morador> moradoresDaUC, ICollection<ContaDeAgua> contasPassadasDoPredio)
        {
            double litrosTotais = contasPassadasDoPredio.Average(x => x.LitrosUtilizados);
            double litrosDaUnidadeConsumidora = 0;

            foreach (var moradorDaUC in moradoresDaUC)
            {
                litrosDaUnidadeConsumidora += litrosTotais * moradorDaUC.CalcularPorcentagemDeUso(moradoresDoPredio);
            }
            MediaDeConsumoMensal = litrosDaUnidadeConsumidora;
            return MediaDeConsumoMensal;
        }
    }
}
