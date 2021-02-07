using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Messenger.Database.Models
{
    public class Messages
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        // int - Id чатов, связный список - история сообщений
        public IEnumerable<IDictionary<int, LinkedList<string>>> Histories { get; set; }
    }
}