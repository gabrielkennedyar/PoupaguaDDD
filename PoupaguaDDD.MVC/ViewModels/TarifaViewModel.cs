using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PoupaguaDDD.MVC.ViewModels
{
    public class TarifaViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o mês e ano desta tarifa")]
        [DataType(DataType.Date)]
        [DisplayName("Mês e ano desta tarifa")]
        public DateTime MesAnoDeReferencia { get; set; }

        [Required(ErrorMessage = "Informe o preço do esgoto por litro utilizado")]
        [Range(typeof(float), "0", "1000000")]
        [DataType(DataType.Currency)]
        [DisplayName("Preço do esgoto por litro utilizado")]
        public float PrecoDoEsgoto { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public virtual ContaDeAguaViewModel ContaDeAgua { get; set; }

        public virtual ICollection<PrecoDaTarifaViewModel> PrecosDasTarifas { get; set; }
    }
}