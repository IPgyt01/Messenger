using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Messenger.Database.Models
{
    public class Message
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        // содержимое сообщения
        public string Content { get; set; }
        // Id отправителя сообщения
        public string AuthorId { get; set; }
        // время отправки сообщения
        public DateTime Time { get; set; }
    }
}