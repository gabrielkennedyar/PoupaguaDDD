using System;
using System.Collections.Generic;

namespace PoupaguaDDD.Domain.Entities
{
    public class Morador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double MediaDeHoras { get; private set; }
        public DateTime DataCadastro { get; set; }

        public int UnidadeConsumidoraId { get; set; }
        public virtual UnidadeConsumidora UnidadeConsumidora { get; set; }

        /// <summary>
        /// Calcula a média de horas que um morador fica em casa de acordo com as horas que ele fica em casa de cada dia da semana
        /// </summary>
        /// <param name="domingo"></param>
        /// <param name="segunda"></param>
        /// <param name="terca"></param>
        /// <param name="quarta"></param>
        /// <param name="quinta"></param>
        /// <param name="sexta"></param>
        /// <param name="sabado"></param>
        /// <returns></returns>
        public double CalcularMediaDeHorasEmCasa(Morador moradorDoPredio, int domingo, int segunda, int terca, int quarta, int quinta, int sexta, int sabado)
        {
            float media = (domingo + segunda + terca + quarta + quinta + sexta + sabado) / 7;
            moradorDoPredio.MediaDeHoras = media;
            return moradorDoPredio.MediaDeHoras;
        }

        /// <summary>
        /// Calcula a média de uso do morador baseado no tempo com que ele fica em casa em comparação com outros moradores do predio
        /// </summary>
        /// <param name="moradoresDoPredio"></param>
        /// <returns></returns>
        public double CalcularPorcentagemDeUso(ICollection<Morador> moradoresDoPredio, Morador moradorParaCalculo)
        {
            double horasEmCasaTotalDosMoradoresDoPredio = 0;

            foreach (var moradorDoPredio in moradoresDoPredio)
            {
                horasEmCasaTotalDosMoradoresDoPredio += moradorDoPredio.MediaDeHoras;
            }
            if (horasEmCasaTotalDosMoradoresDoPredio != 0)
            {
                double porcentagemDeUso = (moradorParaCalculo.MediaDeHoras / horasEmCasaTotalDosMoradoresDoPredio); //retorna um número do formato 0,xx que representa a porcentagem do morador
                return porcentagemDeUso;
            }
            return 0;
        }
    }
}
