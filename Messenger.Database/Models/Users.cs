using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Messenger.Database.Models
{
    public class Users
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        
        // пусть пока будет стринг
        private string ProfileImage { get; set; }
        
        //??
        public IDictionary<int, string> UserRoles { get; set; }

        public bool HasImage() => !string.IsNullOrWhiteSpace(ProfileImage);
    }
}