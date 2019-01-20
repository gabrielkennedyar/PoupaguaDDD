using System;

namespace PoupaguaDDD.Domain.Entities
{
    public class MetaIndividual
    {
        public int Id { get; set; }
        public DateTime MesAno { get; set; }
        public int QuantidadeDeEconomiaEmM3 { get; set; }
        public DateTime DataCadastro { get; set; }

        public int UnidadeConsumidoraId { get; set; }
        public virtual UnidadeConsumidora UnidadeConsumidora { get; set; }

        public bool UltrapassouEconomia(int quantidadeUsadaEmLitros)
        {
            double quantidadeEmM3 = (quantidadeUsadaEmLitros / 1000);
            return (QuantidadeDeEconomiaEmM3 > quantidadeEmM3);
        }

        public double CalculaDiferencaEmM3DaMeta(int quantidadeUsadaEmLitros)
        {
            return (QuantidadeDeEconomiaEmM3 - (quantidadeUsadaEmLitros / 1000));
        }
    }
}
