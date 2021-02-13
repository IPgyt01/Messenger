using System;
using System.Collections.Generic;
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
        // время отправки сообщения
        public DateTime Time { get; set; }
    }
}