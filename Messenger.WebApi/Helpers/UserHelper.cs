using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Messenger.Core;
using Messenger.Database.Context.Users;
using Messenger.Database.Models;

namespace Messenger.WebApi.Helpers
{
    [IoC]
    public sealed class UserHelper : IUserHelper
    {
        private readonly IUserContext _db;

        public UserHelper(IUserContext db)
        {
            _db = db;
        }

        public async Task<Tuple<bool, User>> UserIsValid(User userInfo)
        {
            if (userInfo?.Login is null) return null;
            var user = await _db.GetUserValidation(userInfo.Login);
            return Tuple.Create(user != null && user.Password.Equals(userInfo.Password), user);
        }

        public async Task RegisterUser(User user)
        {
            if (user is null) return;
            await _db.Create(user);
        }
        
        public IEnumerable<User> FindUser(string name) => _db.GetUsersByName(name);
    }
}