using Messenger.Database;
using Messenger.Database.Models;
using MongoDB.Driver;

namespace Messenger.WebApi.Controllers
{
    public class MessageController
    {
        private MessageContext _db = new MessageContext();
        
        public IMongoCollection<Message> Messages => _db.Database.GetCollection<Message>(Collections.Messages);
    }
}