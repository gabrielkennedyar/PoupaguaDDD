﻿using PoupaguaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoupaguaDDD.Infra.Data.EntityConfig
{
    public class UnidadeConsumidoraConfiguration : EntityTypeConfiguration<UnidadeConsumidora>
    {
        public UnidadeConsumidoraConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Apto).IsRequired();

            HasOptional(x => x.PerfilDeConsumo).WithRequired(x => x.UnidadeConsumidora);
            HasOptional(x => x.PontoDeConsumo).WithRequired(x => x.UnidadeConsumidora);
        }
    }
}