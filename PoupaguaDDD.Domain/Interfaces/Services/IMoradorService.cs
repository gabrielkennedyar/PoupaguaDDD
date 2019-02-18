using PoupaguaDDD.Domain.Entities;
using System;
using System.Collections.Generic;

namespace PoupaguaDDD.Domain.Interfaces.Services
{
    public interface IMoradorService : IDisposable
    {
        double CalcularMediaDeHorasEmCasa(Morador moradorDoPredio, int domingo, int segunda, int terca, int quarta, int quinta, int sexta, int sabado);
        double CalcularPorcentagemDeUso(ICollection<Morador> moradoresDoPredio, Morador moradorParaCalculo);
    }
}
