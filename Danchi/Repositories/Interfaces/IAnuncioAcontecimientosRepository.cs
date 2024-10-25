using Danchi.Models;

namespace Danchi.Repositories.Interfaces
{
    public interface IAnuncioAcontecimientosRepository
    {
        Task<List<AnuncioAcontecimientos>> GetAnuncioAcontecimientos();

        Task<bool> PostAnuncioAcontecimientos(AnuncioAcontecimientos AnuncioAcontecimientos);
    }
}
