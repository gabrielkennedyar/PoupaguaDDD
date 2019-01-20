using System;

namespace PoupaguaDDD.Domain.Entities
{
    public class EnderecoCompleto
    {
        public int Id { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
