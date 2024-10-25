using Danchi.Models;
namespace Danchi.Repositories.Interfaces
{
    public interface IChatInternoRepository
    {
        Task<List<ChatInterno>> GetChatInterno();
        Task<bool> PostChatInterno(ChatInterno chatInterno);
    }
}
