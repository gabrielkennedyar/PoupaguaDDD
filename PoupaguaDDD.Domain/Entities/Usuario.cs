using PoupaguaDDD.Domain.Validations.Usuarios;
using System;
using System.Collections.Generic;

namespace PoupaguaDDD.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public virtual string Email { get; set; }
        public virtual bool EmailConfirmed { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual string SecurityStamp { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual bool PhoneNumberConfirmed { get; set; }
        public virtual bool TwoFactorEnabled { get; set; }
        public virtual DateTime? LockoutEndDateUtc { get; set; }
        public virtual bool LockoutEnabled { get; set; }
        public virtual int AccessFailedCount { get; set; }
        public virtual string UserName { get; set; }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNasc { get; set; }
        public bool Ativo { get; set; }
        public bool Excluido { get; set; }

        public virtual EnderecoCompleto Endereco { get; set; }
        public virtual UnidadeConsumidora UnidadeConsumidora { get; set; }

        public override bool EhValido()
        {
            ValidationResult = new UsuarioEstaConsistenteValidation().Validate(this);
            return ValidationResult.IsValid;
        }

        public void AdicionarEndereco(EnderecoCompleto enderecoCompleto)
        {
            if (!enderecoCompleto.EhValido())
            {
                AdicionarErrosValidacao(enderecoCompleto.ValidationResult);
                return;
            }

            Endereco = enderecoCompleto;
        }

        public void DefinirComoAtivo()
        {
            Ativo = true;
            Excluido = false;
        }

        public void DefinirComoExcluido()
        {
            Ativo = false;
            Excluido = true;
        }        
    }
}
