using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoupaguaDDD.Domain.Entities
{
    public class PontoDeConsumo
    {
        public int Id { get; set; }
        public int Apto { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual UnidadeConsumidora UnidadeConsumidora { get; set; }

        public int PredioId { get; set; }
        public virtual Predio Predio { get; set; }
    }
}
