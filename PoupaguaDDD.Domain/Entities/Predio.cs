using System;
using System.Collections.Generic;

namespace PoupaguaDDD.Domain.Entities
{
    public class Predio : EntityBase
    {
        public string Nome { get; set; }

        public virtual EnderecoDoPredio EnderecoDoPredio { get; set; }

        public virtual ICollection<PontoDeConsumo> PontosDeConsumo { get; set; }
        public virtual ICollection<ContaDeAgua> ContasDeAgua { get; set; }
        public virtual ICollection<MetaGeral> MetasGerais { get; set; }
        public virtual ICollection<ValorAlertaGeral> ValoresAlertaGeral { get; set; }

        public override bool EhValido()
        {
            return true; //TODO AdicionarValidationResult
        }
    }
}
