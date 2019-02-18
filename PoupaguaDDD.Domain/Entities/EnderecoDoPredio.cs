using System;

namespace PoupaguaDDD.Domain.Entities
{
    public class EnderecoDoPredio : EntityBase
    {
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bloco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public Predio Predio { get; set; }

        public override bool EhValido()
        {
            return true; //TODO AdicionarValidationResult
        }
    }
}
