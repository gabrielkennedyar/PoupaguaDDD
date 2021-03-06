﻿using PoupaguaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PoupaguaDDD.Infra.Data.EntityConfig
{
    public class UnidadeConsumidoraConfiguration : EntityTypeConfiguration<UnidadeConsumidora>
    {
        public UnidadeConsumidoraConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Apto).IsRequired();

            HasRequired(x => x.Usuario).WithOptional(x => x.UnidadeConsumidora);
            HasOptional(x => x.PerfilDeConsumo).WithRequired(x => x.UnidadeConsumidora);
            HasOptional(x => x.PontoDeConsumo).WithRequired(x => x.UnidadeConsumidora);
        }
    }
}
