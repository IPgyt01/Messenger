﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Messenger.Database.Constants;
using Messenger.Database.Documents;
using Messenger.Database.Mapper;
using Messenger.Database.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Messenger.Database
{
    public sealed class UserContext : DatabaseContext
    {
        public UserContext() : base() { }
        private readonly UserDocumentMapper _userDocumentMapper = new UserDocumentMapper();

        private IMongoCollection<UserDocument> Users => Database.GetCollection<UserDocument>(CollectionsNames.Users);

        [CanBeNull]
        public async Task<User> GetUser([NotNull] string id)
        {
            var user = await Users.Find(new BsonDocument("_id", new ObjectId(id))).FirstOrDefaultAsync();
            return _userDocumentMapper.Map(user);
        }

        // проверка есть ли уже такой логин в бд 
        public async Task<bool> CheckLogin([NotNull] string login) =>
            await Users
                .Find(Builders<UserDocument>.Filter.Eq(u => u.Login, login))
                .FirstOrDefaultAsync() is null;

        [CanBeNull]
        public async Task<User> GetUserValidation([NotNull] string login)
        {
            if (string.IsNullOrWhiteSpace(login))
                return null;
            
            var user = await Users.Find(Builders<UserDocument>.Filter.Eq(u=> u.Login, login)).FirstOrDefaultAsync();
            return _userDocumentMapper.Map(user);
        }

        public async Task Create([NotNull] User user)
        {
            await Users.InsertOneAsync(_userDocumentMapper.Map(user));
        }

        [CanBeNull]
        public IEnumerable<User> GetUsersByName([NotNull] string name)
        {
            return Users
                .Find(Builders<UserDocument>.Filter.Eq(u => u.UserName, name))
                .ToEnumerable()
                .Select(_userDocumentMapper.Map);
        }
    }
}