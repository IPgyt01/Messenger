using System.Collections.Generic;
using Messenger.Database.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Messenger.Database.Documents
{
    public sealed class ChatDocument
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public List<string> UserIds {get;set;}
        public List<Message> History { get; set; }
    }
}