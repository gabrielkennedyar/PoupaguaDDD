using PoupaguaDDD.Application.Interface;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace PoupaguaDDD.Application.ApplicationServices
{
    public class ContaDeAguaAppService : AppServiceBase<ContaDeAgua>, IContaDeAguaAppService
    {
        private readonly IContaDeAguaService _contaDeAguaService;

        public ContaDeAguaAppService(IContaDeAguaService contaDeAguaService) : base(contaDeAguaService)
        {
            _contaDeAguaService = contaDeAguaService;
        }

        public float CalcularPrevisaoDoValorDaConta(ICollection<ContaDeAgua> contasPassadasDoPredio)
        {
            return _contaDeAguaService.CalcularPrevisaoDoValorDaConta(contasPassadasDoPredio);
        }
    }
}
