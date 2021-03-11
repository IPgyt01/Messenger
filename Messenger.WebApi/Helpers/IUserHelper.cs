using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Messenger.Database.Models;

namespace Messenger.WebApi.Helpers
{
    public interface IUserHelper
    {
        Task<Tuple<bool, User>> UserIsValid([CanBeNull] User userInfo);

        Task RegisterUser([CanBeNull] User user);

        [CanBeNull]
        IEnumerable<User> FindUser([NotNull] string name);
    }
}