using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace PoupaguaDDD.Domain.Services
{
    public class ContaDeAguaService : ServiceBase<ContaDeAgua>, IContaDeAguaService
    {
        private readonly IContaDeAguaRepository _contaDeAguaRepository;

        public ContaDeAguaService(IContaDeAguaRepository contaDeAguaRepository) : base(contaDeAguaRepository)
        {
            _contaDeAguaRepository = contaDeAguaRepository;
        }
        public float CalcularPrevisaoDoValorDaConta(ICollection<ContaDeAgua> contasPassadasDoPredio)
        {
            if (contasPassadasDoPredio == null) return 0;
            else return contasPassadasDoPredio.FirstOrDefault(x => x.MesAnoDeReferencia == contasPassadasDoPredio.Max(y => y.MesAnoDeReferencia))
                    .CalcularPrevisaoDoValorDaConta(contasPassadasDoPredio);
        }
    }
}
