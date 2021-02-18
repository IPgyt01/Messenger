using System;

namespace Messenger.Database.Models
{
    // эта модель не будет храниться в отдельной колекции
    // сообщения будут храниться в модели Chat
    public class Message
    {
        // содержимое сообщения
        public string Content { get; set; }
        // Id отправителя сообщения
        public string AuthorId { get; set; }
        // время отправки сообщения
        public DateTime Time { get; set; }
    }
}