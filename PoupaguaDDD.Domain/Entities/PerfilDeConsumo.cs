﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PoupaguaDDD.Domain.Entities
{
    public class PerfilDeConsumo : EntityBase
    {
        public double MediaDeConsumoMensal { get; private set; }

        public virtual UnidadeConsumidora UnidadeConsumidora { get; set; }

        public override bool EhValido()
        {
            return true; //TODO AdicionarValidationResult
        }

        /// <summary>
        /// Calcula os litros utilizados até o dia atual do mes de uma unidade consumidora
        /// </summary>
        /// <param name="moradoresDoPredio"></param>
        /// <param name="moradoresDaUC"></param>
        /// <param name="contasPassadasDoPredio"></param>
        /// <returns></returns>
        public double CalcularQuantDeLitrosAcumuladosNoMes(ICollection<Morador> moradoresDoPredio, ICollection<Morador> moradoresDaUC, ICollection<ContaDeAgua> contasPassadasDoPredio, PerfilDeConsumo perfilDeConsumoDoUsuario)
        {
            int diaAtual = DateTime.Today.Day;
            double consumoDiario = CalcularMediaDiariaDeLitrosUtilizados(moradoresDoPredio, moradoresDaUC, contasPassadasDoPredio, perfilDeConsumoDoUsuario);
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
        public double CalcularMediaDiariaDeLitrosUtilizados(ICollection<Morador> moradoresDoPredio, ICollection<Morador> moradoresDaUC, ICollection<ContaDeAgua> contasPassadasDoPredio, PerfilDeConsumo perfilDeConsumoDoUsuario)
        {
            double mediaMensal = AtribuirMediaDeConsumoMensalDaUC(moradoresDoPredio, moradoresDaUC, contasPassadasDoPredio, perfilDeConsumoDoUsuario);
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
        private double AtribuirMediaDeConsumoMensalDaUC(ICollection<Morador> moradoresDoPredio, ICollection<Morador> moradoresDaUC, ICollection<ContaDeAgua> contasPassadasDoPredio, PerfilDeConsumo perfilDeConsumoDoUsuario)
        {
            double litrosTotais = contasPassadasDoPredio.Average(x => x.LitrosUtilizados);
            double litrosDaUnidadeConsumidora = 0;

            foreach (var moradorDaUC in moradoresDaUC)
            {
                litrosDaUnidadeConsumidora += litrosTotais * moradorDaUC.CalcularPorcentagemDeUso(moradoresDoPredio, moradorDaUC);
            }
            perfilDeConsumoDoUsuario.MediaDeConsumoMensal = litrosDaUnidadeConsumidora;
            return perfilDeConsumoDoUsuario.MediaDeConsumoMensal;
        }
    }
}
