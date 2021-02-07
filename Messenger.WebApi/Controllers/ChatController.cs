using Messenger.Database;
using Messenger.Database.Models;
using MongoDB.Driver;

namespace Messenger.WebApi.Controllers
{
    public class ChatController
    {
        private DatabaseContext _db = new DatabaseContext();

        public IMongoCollection<Chats> Chats => _db.Database.GetCollection<Chats>(Collections.Chats);
    }
}