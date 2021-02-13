using System.Threading.Tasks;
using Messenger.Database;
using Messenger.Database.Models;
using MongoDB.Driver;

namespace Messenger.WebApi.Controllers
{
    public class UserController
    {
        private readonly UserContext _db = new UserContext();

        public async Task<User> UserIsValid(User userInfo)
        {
            var user = await _db.GetUserValidation(userInfo.Login);
            return user.Password.Equals(userInfo.Password) ? user : null;
        }

        public async Task RegisterUser(User user)
        {
            await _db.Create(user);
        }
    }
}