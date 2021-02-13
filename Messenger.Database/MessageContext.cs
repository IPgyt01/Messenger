using Messenger.Database.Models;
using MongoDB.Driver;

namespace Messenger.Database
{
    public class MessageContext : DatabaseContext
    {
        public MessageContext() : base() { }
        
        public IMongoCollection<Message> Messages => Database.GetCollection<Message>(Collections.Messages);

    }
}