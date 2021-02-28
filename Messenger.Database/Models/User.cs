﻿using System.Collections.Generic;

namespace Messenger.Database.Models
{
    public sealed class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<string> Chats { get; set; }
        // пусть пока будет стринг
        public string ProfileImage { get; set; }
        
        public bool HasImage() => !string.IsNullOrWhiteSpace(ProfileImage);
    }
}