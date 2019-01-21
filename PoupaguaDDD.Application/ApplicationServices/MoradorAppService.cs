using PoupaguaDDD.Application.Interface;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace PoupaguaDDD.Application.ApplicationServices
{
    public class MoradorAppService : AppServiceBase<Morador>, IMoradorAppService
    {
        private readonly IMoradorService _moradorService;

        public MoradorAppService(IMoradorService moradorService) : base(moradorService)
        {
            _moradorService = moradorService;
        }

        public double CalcularMediaDeHorasEmCasa(Morador moradorDoPredio, int domingo, int segunda, int terca, int quarta, int quinta, int sexta, int sabado)
        {
            return _moradorService.CalcularMediaDeHorasEmCasa(moradorDoPredio, domingo, segunda, terca, quarta, quinta, sexta, sabado);
        }

        public double CalcularPorcentagemDeUso(ICollection<Morador> moradoresDoPredio, Morador moradorParaCalculo)
        {
            return _moradorService.CalcularPorcentagemDeUso(moradoresDoPredio, moradorParaCalculo);
        }
    }
}
