using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace PoupaguaDDD.Domain.Services
{
    public class MoradorService : IMoradorService
    {
        private readonly IMoradorRepository _moradorRepository;

        public MoradorService(IMoradorRepository moradorRepository)
        {
            _moradorRepository = moradorRepository;
        }

        public double CalcularMediaDeHorasEmCasa(Morador moradorDoPredio, int domingo, int segunda, int terca, int quarta, int quinta, int sexta, int sabado)
        {
            return moradorDoPredio.CalcularMediaDeHorasEmCasa(moradorDoPredio, domingo, segunda, terca, quarta, quinta, sexta, sabado);
        }

        public double CalcularPorcentagemDeUso(ICollection<Morador> moradoresDoPredio, Morador moradorParaCalculo)
        {
            return moradorParaCalculo.CalcularPorcentagemDeUso(moradoresDoPredio, moradorParaCalculo);
        }

        public void Dispose()
        {
            _moradorRepository.Dispose();
        }
    }
}
