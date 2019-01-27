using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PoupaguaDDD.MVC.ViewModels
{
    public class PontoDeConsumoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o número do apartamento")]
        [Range(typeof(int), "0", "1000000")]
        [DisplayName("Apartamento")]
        public int Apto { get; set; }

        [MaxLength(100, ErrorMessage = "Máximo {1} caracteres")]
        public string Nome { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public virtual UnidadeConsumidoraViewModel UnidadeConsumidora { get; set; }

        public int PredioId { get; set; }
        public virtual PredioViewModel Predio { get; set; }
    }
}