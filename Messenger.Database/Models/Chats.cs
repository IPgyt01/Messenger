using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Messenger.Database.Models
{
    public class Chats
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int ChatId {get;set;}
        public int UsersCount {get;set;}
        public IEnumerable<int> UserIds {get;set;}
        public IEnumerable<string> UserRoles { get; set; }
        public IEnumerable<string> MessageHistory { get; set; }
    }
}