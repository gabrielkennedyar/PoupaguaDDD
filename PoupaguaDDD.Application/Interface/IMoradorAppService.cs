using PoupaguaDDD.Domain.Entities;
using System.Collections.Generic;

namespace PoupaguaDDD.Application.Interface
{
    public interface IMoradorAppService : IAppServiceBase<Morador>
    {
        double CalcularMediaDeHorasEmCasa(Morador moradorDoPredio, int domingo, int segunda, int terca, int quarta, int quinta, int sexta, int sabado);
        double CalcularPorcentagemDeUso(ICollection<Morador> moradoresDoPredio, Morador moradorParaCalculo);
    }
}
