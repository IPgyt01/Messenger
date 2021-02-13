using Messenger.Database;
using Messenger.Database.Models;
using MongoDB.Driver;

namespace Messenger.WebApi.Controllers
{
    public class ChatController
    {
        private ChatContext _db = new ChatContext();

        public IMongoCollection<Chat> Chats => _db.Database.GetCollection<Chat>(Collections.Chats);
    }
}