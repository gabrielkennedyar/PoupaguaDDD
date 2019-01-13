using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoupaguaDDD.Domain.Entities
{
    public class Predio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual EnderecoDoPredio EnderecoDoPredio { get; set; }
               
        public virtual ICollection<PontoDeConsumo> PontosDeConsumo { get; set; }
        public virtual ICollection<ContaDeAgua> ContasDeAgua { get; set; }
        public virtual ICollection<MetaGeral> MetasGerais { get; set; }
        public virtual ICollection<ValorAlertaGeral> ValoresAlertaGeral { get; set; }
    }
}
