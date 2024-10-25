using Danchi.Models;

namespace Danchi.Repositories.Interfaces
{
    public interface IAutenticacionUsuarioRepository
    {
        Task<List<AutenticacionUsuario>> GetAutenticacionUsuario();

        Task<bool> PostAutenticacionUsuario(AutenticacionUsuario AutenticacionUsuario);
    }
}
