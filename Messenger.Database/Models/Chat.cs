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
        public List<string> UserIds {get;set;}
        public List<Message> History { get; set; }
        // роли добавим позже, пока только мешаться будут
        //public IEnumerable<string> UserRoles { get; set; }
    }
}