using AutoMapper;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.MVC.ViewModels;

namespace PoupaguaDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile() : base("DomainToViewModelMappingProfile")
        {
            CreateMap<ContaDeAgua, ContaDeAguaViewModel>();
            CreateMap<EnderecoCompleto, EnderecoCompletoViewModel>();
            CreateMap<EnderecoDoPredio, EnderecoDoPredioViewModel>();
            CreateMap<MetaGeral, MetaGeralViewModel>();
            CreateMap<MetaIndividual, MetaIndividualViewModel>();
            CreateMap<Morador, MoradorViewModel>();
            CreateMap<PerfilDeConsumo, PerfilDeConsumoViewModel>();
            CreateMap<PontoDeConsumo, PontoDeConsumoViewModel>();
            CreateMap<PrecoDaTarifa, PrecoDaTarifaViewModel>();
            CreateMap<Predio, PredioViewModel>();
            CreateMap<Tarifa, TarifaViewModel>();
            CreateMap<UnidadeConsumidora, UnidadeConsumidoraViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<ValorAlertaGeral, ValorAlertaGeralViewModel>();
        }
    }
}