using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PoupaguaDDD.MVC.ViewModels
{
    public class PredioViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe um nome para o prédio")]
        [MaxLength(100, ErrorMessage = "Máximo {1} caracteres")]
        public string Nome { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public virtual EnderecoDoPredioViewModel EnderecoDoPredio { get; set; }

        public virtual ICollection<PontoDeConsumoViewModel> PontosDeConsumo { get; set; }
        public virtual ICollection<ContaDeAguaViewModel> ContasDeAgua { get; set; }
        public virtual ICollection<MetaGeralViewModel> MetasGerais { get; set; }
        public virtual ICollection<ValorAlertaGeralViewModel> ValoresAlertaGeral { get; set; }
    }
}