using System;

namespace PoupaguaDDD.Domain.Entities
{
    public class MetaIndividual : EntityBase
    {
        public DateTime MesAno { get; set; }
        public int QuantidadeDeEconomiaEmM3 { get; set; }

        public string UnidadeConsumidoraId { get; set; }
        public virtual UnidadeConsumidora UnidadeConsumidora { get; set; }

        public override bool EhValido()
        {
            return true; //TODO AdicionarValidationResult
        }

        public bool VerificarSeUltrapassouEconomia(MetaIndividual ultimaMetaIndividualDaUC, int quantidadeUsadaEmLitros)
        {
            double quantidadeEmM3 = (quantidadeUsadaEmLitros / 1000);
            return (ultimaMetaIndividualDaUC.QuantidadeDeEconomiaEmM3 > quantidadeEmM3);
        }

        public double CalcularDiferencaEmM3DaMeta(MetaIndividual ultimaMetaIndividualDaUC, int quantidadeUsadaEmLitros)
        {
            return (ultimaMetaIndividualDaUC.QuantidadeDeEconomiaEmM3 - (quantidadeUsadaEmLitros / 1000));
        }
    }
}
