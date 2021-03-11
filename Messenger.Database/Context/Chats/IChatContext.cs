using System.Threading.Tasks;
using JetBrains.Annotations;
using Messenger.Database.Models;

namespace Messenger.Database.Context.Chats
{
    public interface IChatContext
    {
        [CanBeNull]
        Task<Chat> Get([NotNull] string id);

        Task AddMessage([NotNull] string chatId, [NotNull] Message message);

        Task Create([NotNull] Chat chat);
    }
}