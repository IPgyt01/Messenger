using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Messenger.Database;
using Messenger.Database.Models;

namespace Messenger.WebApi.Controllers
{
    public class UserHelper
    {
        private readonly UserContext _db = new UserContext();
        
        public async Task<Tuple<bool, User>> UserIsValid([CanBeNull] User userInfo)
        {
            if (userInfo?.Login is null) return null;
            var user = await _db.GetUserValidation(userInfo.Login);
            return Tuple.Create(user != null && user.Password.Equals(userInfo.Password), user);
        }

        public async Task RegisterUser([CanBeNull] User user)
        {
            if (user is null) return;
            await _db.Create(user);
        }

        [CanBeNull]
        public IEnumerable<User> FindUser([NotNull] string name) => _db.GetUsersByName(name);
    }
}