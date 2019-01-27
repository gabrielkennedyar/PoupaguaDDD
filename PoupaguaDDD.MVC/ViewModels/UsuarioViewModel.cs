using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PoupaguaDDD.MVC.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe um endereço de e-mail")]
        [MaxLength(250, ErrorMessage = "Máximo {1} caracteres")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe um endereço de e-mail")]
        [MaxLength(50, ErrorMessage = "Máximo {1} caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [MaxLength(150, ErrorMessage = "Máximo {1} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {1} caracteres")]
        public string Nome { get; set; }

        [MaxLength(12, ErrorMessage = "Máximo {1} caracteres")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [MaxLength(11, ErrorMessage = "Máximo {1} caracteres")]
        [MinLength(11, ErrorMessage = "Mínimo {1} caracteres")]
        public string CPF { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNasc { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        [DisplayName("Gerente?")]
        public bool Gerente { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public virtual EnderecoCompletoViewModel Endereco { get; set; }
        public virtual UnidadeConsumidoraViewModel UnidadeConsumidora { get; set; }
    }
}