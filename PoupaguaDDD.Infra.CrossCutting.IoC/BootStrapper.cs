using PoupaguaDDD.Application.ApplicationServices;
using PoupaguaDDD.Application.Interface;
using PoupaguaDDD.Domain.Interfaces.Repositories;
using PoupaguaDDD.Domain.Interfaces.Services;
using PoupaguaDDD.Domain.Services;
using PoupaguaDDD.Infra.Data.Context;
using PoupaguaDDD.Infra.Data.Repositories;
using SimpleInjector;

namespace PoupaguaDDD.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static Container MyContainer { get; set; }

        public static void Register(Container container)
        {
            MyContainer = container;

            //Infra Dados
            container.Register<PoupaguaContext>(Lifestyle.Scoped);

            //Base
            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            container.Register(typeof(IRepositoryRead<>), typeof(RepositoryBase<>));
            container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));

            //All
            container.Register<IContaDeAguaService, ContaDeAguaService>(Lifestyle.Scoped);
            container.Register<IContaDeAguaRepository, ContaDeAguaRepository>(Lifestyle.Scoped);
            container.Register<IContaDeAguaAppService, ContaDeAguaAppService>(Lifestyle.Scoped);

            container.Register<IEnderecoCompletoService, EnderecoCompletoService>(Lifestyle.Scoped);
            container.Register<IEnderecoCompletoRepository, EnderecoCompletoRepository>(Lifestyle.Scoped);
            container.Register<IEnderecoCompletoAppService, EnderecoCompletoAppService>(Lifestyle.Scoped);

            container.Register<IEnderecoDoPredioService, EnderecoDoPredioService>(Lifestyle.Scoped);
            container.Register<IEnderecoDoPredioRepository, EnderecoDoPredioRepository>(Lifestyle.Scoped);
            container.Register<IEnderecoDoPredioAppService, EnderecoDoPredioAppService>(Lifestyle.Scoped);

            container.Register<IMetaGeralService, MetaGeralService>(Lifestyle.Scoped);
            container.Register<IMetaGeralRepository, MetaGeralRepository>(Lifestyle.Scoped);
            container.Register<IMetaGeralAppService, MetaGeralAppService>(Lifestyle.Scoped);

            container.Register<IMetaIndividualService, MetaIndividualService>(Lifestyle.Scoped);
            container.Register<IMetaIndividualRepository, MetaIndividualRepository>(Lifestyle.Scoped);
            container.Register<IMetaIndividualAppService, MetaIndividualAppService>(Lifestyle.Scoped);

            container.Register<IMoradorService, MoradorService>(Lifestyle.Scoped);
            container.Register<IMoradorRepository, MoradorRepository>(Lifestyle.Scoped);
            container.Register<IMoradorAppService, MoradorAppService>(Lifestyle.Scoped);

            container.Register<IPerfilDeConsumoService, PerfilDeConsumoService>(Lifestyle.Scoped);
            container.Register<IPerfilDeConsumoRepository, PerfilDeConsumoRepository>(Lifestyle.Scoped);
            container.Register<IPerfilDeConsumoAppService, PerfilDeConsumoAppService>(Lifestyle.Scoped);

            container.Register<IPontoDeConsumoService, PontoDeConsumoService>(Lifestyle.Scoped);
            container.Register<IPontoDeConsumoRepository, PontoDeConsumoRepository>(Lifestyle.Scoped);
            container.Register<IPontoDeConsumoAppService, PontoDeConsumoAppService>(Lifestyle.Scoped);

            container.Register<IPrecoDaTarifaService, PrecoDaTarifaService>(Lifestyle.Scoped);
            container.Register<IPrecoDaTarifaRepository, PrecoDaTarifaRepository>(Lifestyle.Scoped);
            container.Register<IPrecoDaTarifaAppService, PrecoDaTarifaAppService>(Lifestyle.Scoped);

            container.Register<IPredioService, PredioService>(Lifestyle.Scoped);
            container.Register<IPredioRepository, PredioRepository>(Lifestyle.Scoped);
            container.Register<IPredioAppService, PredioAppService>(Lifestyle.Scoped);

            container.Register<ITarifaService, TarifaService>(Lifestyle.Scoped);
            container.Register<ITarifaRepository, TarifaRepository>(Lifestyle.Scoped);
            container.Register<ITarifaAppService, TarifaAppService>(Lifestyle.Scoped);

            container.Register<IUnidadeConsumidoraService, UnidadeConsumidoraService>(Lifestyle.Scoped);
            container.Register<IUnidadeConsumidoraRepository, UnidadeConsumidoraRepository>(Lifestyle.Scoped);
            container.Register<IUnidadeConsumidoraAppService, UnidadeConsumidoraAppService>(Lifestyle.Scoped);

            container.Register<IUsuarioAppService, UsuarioAppService>(Lifestyle.Scoped);
            container.Register<IUsuarioService, UsuarioService>(Lifestyle.Scoped);
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);

            container.Register<IValorAlertaGeralService, ValorAlertaGeralService>(Lifestyle.Scoped);
            container.Register<IValorAlertaGeralRepository, ValorAlertaGeralRepository>(Lifestyle.Scoped);
            container.Register<IValorAlertaGeralAppService, ValorAlertaGeralAppService>(Lifestyle.Scoped);
        }
    }
}
