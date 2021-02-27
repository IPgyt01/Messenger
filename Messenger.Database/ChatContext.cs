using Messenger.Database.Models;
using MongoDB.Driver;

namespace Messenger.Database
{
    public class ChatContext : DatabaseContext
    {
        public ChatContext() : base() { }
        
        public IMongoCollection<Chat> Chats => Database.GetCollection<Chat>(Collections.Chats);
    }
}