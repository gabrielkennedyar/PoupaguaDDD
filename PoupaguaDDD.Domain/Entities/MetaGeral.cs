using System;

namespace PoupaguaDDD.Domain.Entities
{
    public class MetaGeral
    {
        public int Id { get; set; }
        public DateTime MesAno { get; set; }
        public int QuantidadeEmLitros { get; set; }
        public DateTime DataCadastro { get; set; }

        public int PredioId { get; set; }
        public virtual Predio Predio { get; set; }

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
