using JetBrains.Annotations;
using Messenger.Core;
using Messenger.Core.Mapping;
using Messenger.Database.Documents;
using Messenger.Database.Models;

namespace Messenger.Database.Mapper
{
    [IoC]
    public sealed class ChatDocumentMapper : IMapper<Chat, ChatDocument>, IMapper<ChatDocument, Chat>
    {
        [CanBeNull]
        public ChatDocument Map([CanBeNull] Chat source) => source is null 
            ? null 
            : new ChatDocument
            {
                Id = source.Id,
                UserIds = source.UserIds,
                History = source.History,
            };

        [CanBeNull]
        public Chat Map([CanBeNull] ChatDocument source) => source is null 
            ? null 
            : new Chat
            {
                Id = source.Id,
                UserIds = source.UserIds,
                History = source.History,
            };
    }
}