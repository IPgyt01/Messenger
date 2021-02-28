using System.Threading.Tasks;
using JetBrains.Annotations;
using Messenger.Database.Constants;
using Messenger.Database.Documents;
using Messenger.Database.Mapper;
using Messenger.Database.Models;
using MongoDB.Driver;

namespace Messenger.Database
{
    public sealed class ChatContext : DatabaseContext
    {
        public ChatContext() : base() { }
        private readonly ChatDocumentMapper _chatDocumentMapper = new ChatDocumentMapper();
        private IMongoCollection<ChatDocument> Chats => Database.GetCollection<ChatDocument>(CollectionsNames.Chats);

        [CanBeNull]
        public async Task<Chat> Get([NotNull] string id)
        {
            var chat = await Chats.Find(Builders<ChatDocument>.Filter.Eq(c => c.Id, id)).FirstOrDefaultAsync();
            return _chatDocumentMapper.Map(chat);
        }

        public async Task AddMessage([NotNull] string chatId, [NotNull] Message message)
        {
            var chat = await Get(chatId);
            chat?.History.Add(message);
        }
        
        public async Task Create([NotNull] Chat chat)
        {
            await Chats.InsertOneAsync(_chatDocumentMapper.Map(chat));
        }
    }
}