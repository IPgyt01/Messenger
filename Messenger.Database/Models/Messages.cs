using System.Collections.Generic;

namespace Messenger.Database.Models
{
    public class Messages
    {
        // int - Id чатов, связный список - история сообщений
        public IEnumerable<IDictionary<int, LinkedList<string>>> Histories { get; set; }
    }
}