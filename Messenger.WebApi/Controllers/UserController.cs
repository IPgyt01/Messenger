using Messenger.Database;
using Messenger.Database.Models;
using MongoDB.Driver;

namespace Messenger.WebApi.Controllers
{
    public class UserController
    {
        private UserContext _db = new UserContext();

        public IMongoCollection<Users> Users => _db.Database.GetCollection<Users>(Collections.Users);
    }
}