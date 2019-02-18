using System;

namespace PoupaguaDDD.Domain.Entities
{
    public class PrecoDaTarifa : EntityBase
    {
        public int Nivel { get; set; }
        public float PrecoMilLitros { get; set; }

        public string TarifaId { get; set; }
        public virtual Tarifa Tarifa { get; set; }

        public override bool EhValido()
        {
            return true; //TODO AdicionarValidationResult
        }

        public float CalcularPreco(PrecoDaTarifa precoDaTarifaParaCalculo, int mediaDeLitros)
        {
            return ((mediaDeLitros / 1000) * precoDaTarifaParaCalculo.PrecoMilLitros);
        }
    }
}
