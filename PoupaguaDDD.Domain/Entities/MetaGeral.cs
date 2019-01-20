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

        public bool UltrapassouMetaDeUso(int quantidadeUsadaEmLitros)
        {
            return (quantidadeUsadaEmLitros > QuantidadeEmLitros);
        }

        public double CalculaDiferencaEmLitrosDaMeta(int quantidadeUsadaEmLitros)
        {
            return (QuantidadeEmLitros - quantidadeUsadaEmLitros);
        }
    }
}
