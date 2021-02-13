using System;
using System.Threading.Tasks;
using Messenger.Database.Models;
using Messenger.WebApi.Controllers;

namespace Messenger.WebApi
{
    public class UserAuthorize : UserController
    {
        private readonly User _user;
        
        public UserAuthorize(User user)
        {
            _user = user;
        }

        // при проверке будет создаваться экземпляр User с введеными полями при авторизации
        // если данные введены верно, то результат будет true и вернется полный User из БД
        public async Task<Tuple<bool, User>> IsValid()
        {
            var user = await UserIsValid(_user);
            return Tuple.Create(user != null, user);
        }
    }
}