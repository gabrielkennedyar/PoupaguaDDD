using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PoupaguaDDD.MVC.ViewModels
{
    public class ContaDeAguaViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o mês e ano de referência")]
        [DataType(DataType.Date)]
        [DisplayName("Mes e ano de referência da conta")]
        public DateTime MesAnoDeReferencia { get; set; }

        [Required(ErrorMessage = "Preencha o dia de vencimento da conta")]
        [Range(typeof(int), "1", "31")]
        [DisplayName("Dia do vencimento desta conta")]
        public int DiaDeVencimento { get; set; }

        [Required(ErrorMessage = "Preencha o valor de litros utilizados")]
        [Range(typeof(int), "0", "1000000")]
        [DisplayName("Litros utilizados nesta conta de água")]
        public int LitrosUtilizados { get; set; }

        [Required(ErrorMessage = "Digite o valor de pagamento desta conta")]
        [Range(typeof(float), "0", "1000000")]
        [DisplayName("Valor de pagamento desta conta")]
        public float ValorDePagamento { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public virtual TarifaViewModel Tarifa { get; set; }

        public int PredioId { get; set; }
        public virtual PredioViewModel Predio { get; set; }
    }
}