using System;

namespace PoupaguaDDD.Domain.Entities
{
    public class MetaGeral : EntityBase
    {
        public DateTime MesAno { get; set; }
        public int QuantidadeEmLitros { get; set; }

        public string PredioId { get; set; }
        public virtual Predio Predio { get; set; }

        public override bool EhValido()
        {
            return true; //TODO AdicionarValidationResult
        }

        public bool VerificarSeUltrapassouMetaDeUso(MetaGeral ultimaMetaGeralDoPredio, int quantidadeUsadaEmLitros)
        {
            return (quantidadeUsadaEmLitros > ultimaMetaGeralDoPredio.QuantidadeEmLitros);
        }

        public double CalcularDiferencaEmLitrosDaMeta(MetaGeral ultimaMetaGeralDoPredio, int quantidadeUsadaEmLitros)
        {
            return (ultimaMetaGeralDoPredio.QuantidadeEmLitros - quantidadeUsadaEmLitros);
        }
    }
}
