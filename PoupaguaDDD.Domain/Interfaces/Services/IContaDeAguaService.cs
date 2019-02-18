using PoupaguaDDD.Domain.Entities;
using System;
using System.Collections.Generic;

namespace PoupaguaDDD.Domain.Interfaces.Services
{
    public interface IContaDeAguaService : IDisposable
    {
        float CalcularPrevisaoDoValorDaConta(ICollection<ContaDeAgua> contasPassadasDoPredio);
    }
}
