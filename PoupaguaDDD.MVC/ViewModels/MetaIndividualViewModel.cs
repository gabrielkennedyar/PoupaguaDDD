using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PoupaguaDDD.MVC.ViewModels
{
    public class MetaIndividualViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o mês e ano para a meta")]
        [DataType(DataType.Date)]
        [DisplayName("Mês e ano da meta individual")]
        public DateTime MesAno { get; set; }

        [Required(ErrorMessage = "Infome a quantidade em metros cúbicos para economizar neste mês")]
        [Range(typeof(int), "0", "1000")]
        [DisplayName("Quantidade em metros cúbicos para economizar neste mês")]
        public int QuantidadeDeEconomiaEmM3 { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public int UnidadeConsumidoraId { get; set; }
        public virtual UnidadeConsumidoraViewModel UnidadeConsumidora { get; set; }
    }
}