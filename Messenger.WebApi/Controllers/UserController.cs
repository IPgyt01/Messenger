using Messenger.Database;
using Messenger.Database.Models;
using MongoDB.Driver;

namespace Messenger.WebApi.Controllers
{
    public class UserController
    {
        private UserContext _db = new UserContext();

        public IMongoCollection<User> Users => _db.Database.GetCollection<User>(Collections.Users);
    }
}