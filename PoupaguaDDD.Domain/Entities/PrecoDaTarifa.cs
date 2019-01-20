using System;

namespace PoupaguaDDD.Domain.Entities
{
    public class PrecoDaTarifa
    {
        public int Id { get; set; }
        public int Nivel { get; set; }
        public float PrecoMilLitros { get; set; }
        public DateTime DataCadastro { get; set; }

        public int TarifaId { get; set; }
        public virtual Tarifa Tarifa { get; set; }

        public float CalcularPreco(PrecoDaTarifa precoDaTarifaParaCalculo, int mediaDeLitros)
        {
            return ((mediaDeLitros / 1000) * precoDaTarifaParaCalculo.PrecoMilLitros);
        }
    }
}
