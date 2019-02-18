using PoupaguaDDD.Domain.Entities;
using System;

namespace PoupaguaDDD.Domain.Interfaces.Services
{
    public interface ITarifaService : IDisposable
    {
        float CalcularTarifa(Tarifa tarifaParaCalculo, int mediaDeLitros);
    }
}
