using System;

namespace PoupaguaDDD.Domain.Entities
{
    public class ValorAlertaGeral : EntityBase
    {
        public DateTime MesAno { get; set; }
        public int QuantidadeEmLitros { get; set; }

        public string PredioId { get; set; }
        public virtual Predio Predio { get; set; }

        public override bool EhValido()
        {
            return true; //TODO AdicionarValidationResult
        }
    }
}
