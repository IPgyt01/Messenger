using Messenger.Database;
using Messenger.Database.Models;
using MongoDB.Driver;

namespace Messenger.WebApi.Controllers
{
    public class MessageController
    {
        private MessageContext _db = new MessageContext();
        
        public IMongoCollection<Messages> Messages => _db.Database.GetCollection<Messages>(Collections.Messages);
    }
}