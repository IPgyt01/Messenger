using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Messenger.Database.Models;

namespace Messenger.Database.Context.Users
{
    public interface IUserContext
    {
        [CanBeNull]
        Task<User> GetUser([NotNull] string id);

        Task<bool> CheckLogin([NotNull] string login);

        [CanBeNull]
        Task<User> GetUserValidation([NotNull] string login);

        Task Create([NotNull] User user);

        [CanBeNull]
        IEnumerable<User> GetUsersByName([NotNull] string name);
    }
}