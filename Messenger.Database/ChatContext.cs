using System.Threading.Tasks;
using Messenger.Database.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Messenger.Database
{
    public class ChatContext : DatabaseContext
    {
        public ChatContext() : base() { }

        public IMongoCollection<Chat> Chats => Database.GetCollection<Chat>(Collections.Chats);

        public async Task<Chat> Get(string id)
        {
            return await Chats.Find(new BsonDocument("_id", new ObjectId(id))).FirstOrDefaultAsync();
        }

        public async Task<Chat> Get(int id)
        {
            return await Chats.Find(new BsonDocument("ChatId", id)).FirstOrDefaultAsync();
        }
        
        public async Task Add(Chat chat)
        {
            await Chats.InsertOneAsync(chat);
        }

        public async Task AddMessage(string id, Message message)
        {
            var chat = await Get(id);
            chat.History.Add(message);
        }
    }
}