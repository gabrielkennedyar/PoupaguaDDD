using AutoMapper;
using PoupaguaDDD.Domain.Entities;
using PoupaguaDDD.MVC.ViewModels;

namespace PoupaguaDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile() : base("ViewModelToDomainProfile")
        {
            CreateMap<ContaDeAguaViewModel, ContaDeAgua>();
            CreateMap<EnderecoCompletoViewModel, EnderecoCompleto>();
            CreateMap<EnderecoDoPredioViewModel, EnderecoDoPredio>();
            CreateMap<MetaGeralViewModel, MetaGeral>();
            CreateMap<MetaIndividualViewModel, MetaIndividual>();
            CreateMap<MoradorViewModel, Morador>();
            CreateMap<PerfilDeConsumoViewModel, PerfilDeConsumo>();
            CreateMap<PontoDeConsumoViewModel, PontoDeConsumo>();
            CreateMap<PrecoDaTarifaViewModel, PrecoDaTarifa>();
            CreateMap<PredioViewModel, Predio>();
            CreateMap<TarifaViewModel, Tarifa>();
            CreateMap<UnidadeConsumidoraViewModel, UnidadeConsumidora>();
            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<ValorAlertaGeralViewModel, ValorAlertaGeral>();
        }
    }
}