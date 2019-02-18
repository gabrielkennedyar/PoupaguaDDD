using DomainValidation.Validation;
using System;

namespace PoupaguaDDD.Domain.Entities
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            Id = Guid.NewGuid().ToString();
            ValidationResult = new ValidationResult();
        }

        public string Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public ValidationResult ValidationResult { get; set; }

        public void AdicionarErroValidacao(string erro, string message)
        {
            ValidationResult.Add(new ValidationError(message));
        }

        public void AdicionarErrosValidacao(ValidationResult validationResult)
        {
            ValidationResult.Add(validationResult);
        }

        public void ZerarListaErros()
        {
            ValidationResult = new ValidationResult();
        }

        public abstract bool EhValido();
    }
}
