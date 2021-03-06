﻿using PoupaguaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PoupaguaDDD.Infra.Data.EntityConfig
{
    public class EnderecoCompletoConfiguration : EntityTypeConfiguration<EnderecoCompleto>
    {
        public EnderecoCompletoConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.CEP).IsRequired().HasMaxLength(8).IsFixedLength();
            Property(x => x.Logradouro).IsRequired().HasMaxLength(250);
            Property(x => x.Numero).IsRequired();
            Property(x => x.Complemento).IsRequired();
            Property(x => x.Bairro).IsRequired();
            Property(x => x.Cidade).IsRequired();
            Property(x => x.Estado).IsRequired().HasColumnType("char").HasMaxLength(2);
            Property(x => x.Pais).IsRequired();
        }
    }
}
