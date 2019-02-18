using System;
using System.Collections.Generic;
using System.Linq;

namespace PoupaguaDDD.Domain.Entities
{
    public class ContaDeAgua : EntityBase
    {
        public DateTime MesAnoDeReferencia { get; set; }
        public int DiaDeVencimento { get; set; }
        public int LitrosUtilizados { get; set; }
        public float ValorDePagamento { get; set; }

        public virtual Tarifa Tarifa { get; set; }

        public string PredioId { get; set; }
        public virtual Predio Predio { get; set; }

        public override bool EhValido()
        {
            return true; //TODO AdicionarValidationResult
        }

        /// <summary>
        /// Tenta prevê o valor de pagamento do mês atual a partir das contas de águas anteriores à este mês
        /// </summary>
        /// <param name="contasPassadasDoPredio"></param>
        /// <returns></returns>
        public float CalcularPrevisaoDoValorDaConta(ICollection<ContaDeAgua> contasPassadasDoPredio, ContaDeAgua ultimaContaDeAguaDoPredio)
        {
            int mediaDeConsumoGeralDoPredio = Convert.ToInt32((CalcularMediaDeConsumoGeral(contasPassadasDoPredio)));
            float previsaoDoValorDaConta = ultimaContaDeAguaDoPredio.Tarifa.CalcularTarifa(ultimaContaDeAguaDoPredio.Tarifa, mediaDeConsumoGeralDoPredio); //Verificar como o entity framework irá mapear o ICollection
            return previsaoDoValorDaConta;
        }

        /// <summary>
        /// Calcula a média total de consumo de litros de água utilizados por um prédio a partir das contas de água passadas
        /// </summary>
        /// <param name="contasPassadasDoPredio"></param>
        /// <returns></returns>
        private double CalcularMediaDeConsumoGeral(ICollection<ContaDeAgua> contasPassadasDoPredio)
        {
            int quantContasAnteriores = contasPassadasDoPredio.Count();
            int somaDosLitros = 0;
            double mediaConsumoGeral;
            foreach (var conta in contasPassadasDoPredio)
            {
                somaDosLitros += conta.LitrosUtilizados;
            }
            return mediaConsumoGeral = somaDosLitros / quantContasAnteriores;
        }
    }
}
