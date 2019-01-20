using System;

namespace PoupaguaDDD.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public DateTime DataNasc { get; set; }
        public bool Ativo { get; set; }
        public bool Gerente { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual EnderecoCompleto Endereco { get; set; }
        public virtual UnidadeConsumidora UnidadeConsumidora { get; set; }
    }
}
