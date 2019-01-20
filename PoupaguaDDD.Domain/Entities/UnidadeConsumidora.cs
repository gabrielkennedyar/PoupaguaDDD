using System;
using System.Collections.Generic;

namespace PoupaguaDDD.Domain.Entities
{
    public class UnidadeConsumidora
    {
        public int Id { get; set; }
        public int Apto { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual PerfilDeConsumo PerfilDeConsumo { get; set; }
        public virtual PontoDeConsumo PontoDeConsumo { get; set; }

        public virtual ICollection<Morador> Moradores { get; set; }

        public virtual ICollection<MetaIndividual> MetasIndividuais { get; set; }
    }
}
