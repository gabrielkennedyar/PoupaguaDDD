using System;
using System.ComponentModel.DataAnnotations;

namespace PoupaguaDDD.MVC.ViewModels
{
    public class PerfilDeConsumoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Editable(false)]
        public double MediaDeConsumoMensal { get; private set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public virtual UnidadeConsumidoraViewModel UnidadeConsumidora { get; set; }
    }
}