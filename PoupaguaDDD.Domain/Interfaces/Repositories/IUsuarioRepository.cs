using PoupaguaDDD.Domain.Entities;

namespace PoupaguaDDD.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepositoryRead<Usuario>, IRepositoryWrite<Usuario>
    {
        /// <summary>
        /// Retorna, se existir, o usuário com o e-mail passado por parâmetro
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Usuario BuscarPorEmail(string email);
        /// <summary>
        /// Retorna, se existir, o usuário com o cpf passado por parâmetro
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        Usuario BuscarPorCpf(string cpf);
    }
}
