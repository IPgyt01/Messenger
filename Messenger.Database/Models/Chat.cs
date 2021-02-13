using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Messenger.Database.Models
{
    public class Chat
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int ChatId {get;set;}
        public int UsersCount {get;set;}
        public IEnumerable<int> UserIds {get;set;}
        public IEnumerable<Message> History { get; set; }
        // роли добавим позже, пока только мешаться будут
        //public IEnumerable<string> UserRoles { get; set; }
    }
}