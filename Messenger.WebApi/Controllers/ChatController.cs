using System.Collections.Generic;
using System.Threading.Tasks;
using Messenger.Database;
using Messenger.Database.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Messenger.WebApi.Controllers
{
    public class ChatController
    {
        public ChatContext Db { get; set; } = new ChatContext();

        public async Task<IEnumerable<Chat>> GetChats()
        {
            return await Db.Chats.Find(new BsonDocument()).ToListAsync();
        }
    }
}