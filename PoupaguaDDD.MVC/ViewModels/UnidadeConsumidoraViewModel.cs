using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PoupaguaDDD.MVC.ViewModels
{
    public class UnidadeConsumidoraViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o apartamento desta unidade consumidora")]
        [DisplayName("Apartamento")]
        public int Apto { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public virtual UsuarioViewModel Usuario { get; set; }
        public virtual PerfilDeConsumoViewModel PerfilDeConsumo { get; set; }
        public virtual PontoDeConsumoViewModel PontoDeConsumo { get; set; }

        public virtual ICollection<MoradorViewModel> Moradores { get; set; }

        public virtual ICollection<MetaIndividualViewModel> MetasIndividuais { get; set; }
    }
}