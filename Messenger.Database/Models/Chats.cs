using System.Collections.Generic;

namespace Messenger.Database.Models
{
    public class Chats
    {
        public int ChatId {get;set;}
        public int UsersCount {get;set;}
        public IEnumerable<int> UserIds {get;set;}
        public IEnumerable<string> UserRoles { get; set; }
        public IEnumerable<string> MessageHistory { get; set; }
    }
}