using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Messenger.Core;
using Messenger.Database.Constants;
using Messenger.Database.Documents;
using Messenger.Database.Mapper;
using Messenger.Database.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Messenger.Database.Context.Users
{
    [IoC]
    public sealed class UserContext : DatabaseContext, IUserContext
    {
        public UserContext() : base() { }
        private readonly UserDocumentMapper _userDocumentMapper = new UserDocumentMapper();

        private IMongoCollection<UserDocument> Users => Database.GetCollection<UserDocument>(CollectionsNames.Users);
        
        public async Task<User> GetUser(string id)
        {
            var user = await Users.Find(new BsonDocument("_id", new ObjectId(id))).FirstOrDefaultAsync();
            return _userDocumentMapper.Map(user);
        }

        // проверка есть ли уже такой логин в бд 
        public async Task<bool> CheckLogin(string login) =>
            await Users
                .Find(Builders<UserDocument>.Filter.Eq(u => u.Login, login))
                .FirstOrDefaultAsync() is null;
        
        public async Task<User> GetUserValidation(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
                return null;
            
            var user = await Users.Find(Builders<UserDocument>.Filter.Eq(u=> u.Login, login)).FirstOrDefaultAsync();
            return _userDocumentMapper.Map(user);
        }

        public async Task Create(User user)
        {
            await Users.InsertOneAsync(_userDocumentMapper.Map(user));
        }
        
        public IEnumerable<User> GetUsersByName(string name)
        {
            return Users
                .Find(Builders<UserDocument>.Filter.Eq(u => u.UserName, name))
                .ToEnumerable()
                .Select(_userDocumentMapper.Map);
        }
    }
}