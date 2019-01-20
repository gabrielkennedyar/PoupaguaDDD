using PoupaguaDDD.Domain.Entities;
using System.Collections.Generic;

namespace PoupaguaDDD.Domain.Interfaces.Services
{
    public interface IContaDeAguaService : IServiceBase<ContaDeAgua>
    {
        float CalcularPrevisaoDoValorDaConta(ICollection<ContaDeAgua> contasPassadasDoPredio);
    }
}
