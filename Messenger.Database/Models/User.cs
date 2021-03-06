﻿using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Messenger.Database.Models
{
    public class User
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<string> Chats { get; set; }
        // пусть пока будет стринг
        public string ProfileImage { get; set; }
        
        //later
        //public IDictionary<int, string> UserRoles { get; set; }
        public bool HasImage() => !string.IsNullOrWhiteSpace(ProfileImage);
    }
}