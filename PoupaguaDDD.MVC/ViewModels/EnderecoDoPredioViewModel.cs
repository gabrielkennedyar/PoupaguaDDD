using System;
using System.ComponentModel.DataAnnotations;

namespace PoupaguaDDD.MVC.ViewModels
{
    public class EnderecoDoPredioViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o CEP")]
        [MaxLength(8, ErrorMessage = "Máximo {1} caracteres")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Informe o Logradouro (ex: rua, avenida, praça)")]
        [MaxLength(250, ErrorMessage = "Máximo {1} caracteres")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Informe o número")]
        [Range(typeof(int), "0", "1000000")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Informe o bloco")]
        [MaxLength(100, ErrorMessage = "Máximo {1} caracteres")]
        public string Bloco { get; set; }

        [Required(ErrorMessage = "Informe o bairro")]
        [MaxLength(100, ErrorMessage = "Máximo {1} caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Informe a cidade")]
        [MaxLength(100, ErrorMessage = "Máximo {1} caracteres")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Informe o estado")]
        [MaxLength(2, ErrorMessage = "Máximo {1} caracteres")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Informe o país")]
        [MaxLength(100, ErrorMessage = "Máximo {1} caracteres")]
        public string Pais { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public PredioViewModel Predio { get; set; }
    }
}