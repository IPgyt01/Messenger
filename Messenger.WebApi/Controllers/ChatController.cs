using System.Threading.Tasks;
using Messenger.Database;
using Messenger.Database.Models;
using MongoDB.Driver;

namespace Messenger.WebApi.Controllers
{
    public class ChatController
    {
        private readonly ChatContext _db = new ChatContext();

        public async Task<Chat> GetChat(string id)
        {
            return await _db.Get(id);
        }

        public async Task<Chat> GetChat(int id)
        {
            return await _db.Get(id);
        }
        
        public async Task CreateChat(Chat chat)
        {
            await _db.Add(chat);
        }

        public async Task AddMessage(string id, Message message)
        {
            await _db.AddMessage(id, message);
        }
    }
}