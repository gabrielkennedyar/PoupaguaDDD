using PoupaguaDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PoupaguaDDD.Infra.Data.EntityConfig
{
    public class ContaDeAguaConfiguration : EntityTypeConfiguration<ContaDeAgua>
    {
        public ContaDeAguaConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.MesAnoDeReferencia).IsRequired();
            Property(x => x.DiaDeVencimento).IsRequired();
            Property(x => x.LitrosUtilizados).IsRequired();
            Property(x => x.ValorDePagamento).IsRequired();

            HasRequired(x => x.Predio).WithMany(x => x.ContasDeAgua).HasForeignKey(x => x.PredioId);
            HasRequired(x => x.Tarifa).WithRequiredPrincipal(x => x.ContaDeAgua);
        }
    }
}
