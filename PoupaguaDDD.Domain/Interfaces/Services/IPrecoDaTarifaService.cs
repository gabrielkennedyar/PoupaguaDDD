using PoupaguaDDD.Domain.Entities;
using System;

namespace PoupaguaDDD.Domain.Interfaces.Services
{
    public interface IPrecoDaTarifaService : IDisposable
    {
        float CalcularPreco(PrecoDaTarifa precoDaTarifaParaCalculo, int mediaDeLitros);
    }
}
