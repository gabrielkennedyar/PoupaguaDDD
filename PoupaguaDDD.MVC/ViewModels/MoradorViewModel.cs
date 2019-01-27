using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PoupaguaDDD.MVC.ViewModels
{
    public class MoradorViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do morador")]
        [MaxLength(100, ErrorMessage = "Máximo {1} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {1} caracteres")]
        public string Nome { get; set; }

        [Editable(false)]
        [DisplayName("Media de horas em casa do morador")]
        public double MediaDeHoras { get; private set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public int UnidadeConsumidoraId { get; set; }
        public virtual UnidadeConsumidoraViewModel UnidadeConsumidora { get; set; }
    }
}