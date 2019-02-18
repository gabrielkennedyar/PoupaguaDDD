using System;

namespace PoupaguaDDD.Domain.Entities
{
    public class PontoDeConsumo : EntityBase
    {
        public int Apto { get; set; }
        public string Nome { get; set; }

        public virtual UnidadeConsumidora UnidadeConsumidora { get; set; }

        public string PredioId { get; set; }
        public virtual Predio Predio { get; set; }

        public override bool EhValido()
        {
            return true; //TODO AdicionarValidationResult
        }
    }
}
