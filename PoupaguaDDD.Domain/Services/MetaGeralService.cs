﻿using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;

namespace PoupaguaDDD.Domain.Services
{
    public class MetaGeralService : IMetaGeralService
    {
        private readonly IMetaGeralRepository _metaGeralRepository;

        public MetaGeralService(IMetaGeralRepository metaGeralRepository)
        {
            _metaGeralRepository = metaGeralRepository;
        }

        public double CalcularDiferencaEmLitrosDaMeta(MetaGeral ultimaMetaGeralDoPredio, int quantidadeUsadaEmLitros)
        {
            return ultimaMetaGeralDoPredio.CalcularDiferencaEmLitrosDaMeta(ultimaMetaGeralDoPredio, quantidadeUsadaEmLitros);
        }        

        public bool VerificarSeUltrapassouMetaDeUso(MetaGeral ultimaMetaGeralDoPredio, int quantidadeUsadaEmLitros)
        {
            return ultimaMetaGeralDoPredio.VerificarSeUltrapassouMetaDeUso(ultimaMetaGeralDoPredio, quantidadeUsadaEmLitros);
        }

        public void Dispose()
        {
            _metaGeralRepository.Dispose();
        }
    }
}
