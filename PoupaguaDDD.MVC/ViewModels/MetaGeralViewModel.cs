using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PoupaguaDDD.MVC.ViewModels
{
    public class MetaGeralViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o mês e ano para a meta")]
        [DataType(DataType.Date)]
        [DisplayName("Mês e ano da meta geral")]
        public DateTime MesAno { get; set; }

        [Required(ErrorMessage = "Informe a quantidade em litros para economizar neste mês")]
        [Range(typeof(int), "0", "1000000")]
        [DisplayName("Quantidade em litros para economizar neste mês")]
        public int QuantidadeEmLitros { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public int PredioId { get; set; }
        public virtual PredioViewModel Predio { get; set; }
    }
}