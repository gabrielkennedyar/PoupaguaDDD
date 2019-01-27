using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PoupaguaDDD.MVC.ViewModels
{
    public class ValorAlertaGeralViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o mês e ano do aviso")]
        [DataType(DataType.Date)]
        [DisplayName("Mês ano deste aviso")]
        public DateTime MesAno { get; set; }

        [Required(ErrorMessage = "Informe a quantidade em litros para o aviso")]
        [Range(typeof(int), "0", "1000000")]
        [DisplayName("Quantidade em litros para ativar alerta neste mês")]
        public int QuantidadeEmLitros { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public int PredioId { get; set; }
        public virtual PredioViewModel Predio { get; set; }
    }
}