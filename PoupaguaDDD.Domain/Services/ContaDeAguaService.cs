﻿using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace PoupaguaDDD.Domain.Services
{
    public class ContaDeAguaService : IContaDeAguaService
    {
        private readonly IContaDeAguaRepository _contaDeAguaRepository;

        public ContaDeAguaService(IContaDeAguaRepository contaDeAguaRepository)
        {
            _contaDeAguaRepository = contaDeAguaRepository;
        }

        public float CalcularPrevisaoDoValorDaConta(ICollection<ContaDeAgua> contasPassadasDoPredio)
        {
            if (contasPassadasDoPredio == null)
            {
                return 0;
            }
            else
            {
                ContaDeAgua ultimaContaDeAguaDoPredio = contasPassadasDoPredio.FirstOrDefault(x => x.MesAnoDeReferencia == contasPassadasDoPredio.Max(y => y.MesAnoDeReferencia));
                return ultimaContaDeAguaDoPredio.CalcularPrevisaoDoValorDaConta(contasPassadasDoPredio, ultimaContaDeAguaDoPredio);
            }
            
        }

        public void Dispose()
        {
            _contaDeAguaRepository.Dispose();
        }
    }
}
