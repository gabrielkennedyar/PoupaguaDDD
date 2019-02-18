using System;
using System.Collections.Generic;
using System.Linq;

namespace PoupaguaDDD.Domain.Entities
{
    public class Tarifa : EntityBase
    {
        public DateTime MesAnoDeReferencia { get; set; }
        public float PrecoDoEsgoto { get; set; }

        public virtual ContaDeAgua ContaDeAgua { get; set; }

        public virtual ICollection<PrecoDaTarifa> PrecosDasTarifas { get; set; }

        public override bool EhValido()
        {
            return true; //TODO AdicionarValidationResult
        }

        public float CalcularTarifa(Tarifa tarifaParaCalculo, int mediaDeLitros)
        {
            float precoEstimado = tarifaParaCalculo.PrecosDasTarifas.Sum(x => x.CalcularPreco(x, mediaDeLitros)); //Verificar como o entity framework irá mapear o ICollection

            if (tarifaParaCalculo.PrecoDoEsgoto != 0)
            {
                precoEstimado *= tarifaParaCalculo.PrecoDoEsgoto;
            }
            return precoEstimado;
        }
    }
}
