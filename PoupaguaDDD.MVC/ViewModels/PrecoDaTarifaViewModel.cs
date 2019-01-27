using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PoupaguaDDD.MVC.ViewModels
{
    public class PrecoDaTarifaViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nível máximo de litros para este preço")]
        [Range(typeof(int), "0", "1000000")]
        [DisplayName("Nível de litros máximo para este preço de tarifa")]
        public int Nivel { get; set; }

        [Required(ErrorMessage = "Informe o preço por mil litros")]
        [Range(typeof(float), "0", "1000000")]
        [DataType(DataType.Currency)]
        [DisplayName("Preço por mil litros")]
        public float PrecoMilLitros { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public int TarifaId { get; set; }
        public virtual TarifaViewModel Tarifa { get; set; }
    }
}