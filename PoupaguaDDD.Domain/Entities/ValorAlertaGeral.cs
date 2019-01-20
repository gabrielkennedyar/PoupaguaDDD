using System;

namespace PoupaguaDDD.Domain.Entities
{
    public class ValorAlertaGeral
    {
        public int Id { get; set; }
        public DateTime MesAno { get; set; }
        public int QuantidadeEmLitros { get; set; }
        public DateTime DataCadastro { get; set; }

        public int PredioId { get; set; }
        public virtual Predio Predio { get; set; }
    }
}
