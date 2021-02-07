using Messenger.Database;
using Messenger.Database.Models;
using MongoDB.Driver;

namespace Messenger.WebApi.Controllers
{
    public class MessageController
    {
        private DatabaseContext _db = new DatabaseContext();
        
        public IMongoCollection<Messages> Messages => _db.Database.GetCollection<Messages>(Collections.Messages);
    }
}