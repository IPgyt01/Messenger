using Messenger.Core;
using Messenger.Database.Context.Chats;

namespace Messenger.WebApi.Helpers
{
    [IoC]
    public sealed class ChatHelper : IChatHelper
    {
        private IChatContext _db;

        public ChatHelper(IChatContext db)
        {
            _db = db;
        }
        
        
    }
}