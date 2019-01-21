using PoupaguaDDD.Domain.Entities;
using System.Collections.Generic;

namespace PoupaguaDDD.Application.Interface
{
    public interface IContaDeAguaAppService : IAppServiceBase<ContaDeAgua>
    {
        float CalcularPrevisaoDoValorDaConta(ICollection<ContaDeAgua> contasPassadasDoPredio);
    }
}
