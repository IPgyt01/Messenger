using System.Collections.Generic;

namespace Messenger.Database.Models
{
    public sealed class Chat
    {
        public string Id { get; set; }
        public List<string> UserIds {get;set;}
        public List<Message> History { get; set; }
    }
}