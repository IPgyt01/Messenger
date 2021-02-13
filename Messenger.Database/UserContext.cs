using System.Threading.Tasks;
using Messenger.Database.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Messenger.Database
{
    public class UserContext : DatabaseContext
    {
        public UserContext() : base() { }

        public IMongoCollection<User> Users => Database.GetCollection<User>(Collections.Users);

        public async Task<User> GetUser(string id)
        {
            return await Users.Find(new BsonDocument("_id", new ObjectId(id))).FirstOrDefaultAsync();
        }

        // с именами у меня очень туго
        public async Task<User> GetUserValidation(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
                return null;
            var builder = new FilterDefinitionBuilder<User>();
            var filter = builder.Empty;

            filter &= builder.Regex("Login", new BsonRegularExpression(login));
            //filter &= builder.Regex("Password", new BsonRegularExpression(passwordHash.AsInt32));
            return await Users.Find(filter).FirstOrDefaultAsync();
        }

        public async Task Create(User user)
        {
            await Users.InsertOneAsync(user);
        }
    }
}