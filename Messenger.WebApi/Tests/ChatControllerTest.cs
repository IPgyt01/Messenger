using System;
using System.Collections.Generic;
using Messenger.Database.Models;
using Messenger.WebApi.Controllers;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Messenger.WebApi.Tests
{
    [TestFixture]
    public class ChatControllerTest
    {
        [Test]
        public async Task Test()
        {
            var chat = new Chat()
            {
                ChatId = 1,
                UserIds = new List<string> {"1"},
                History = new List<Message>()
            };

            var message1 = new Message
            {
                AuthorId = "1",
                Content = "1",
                Time = DateTime.Now
            };
            var message2 = new Message
            {
                AuthorId = "1",
                Content = "2",
                Time = DateTime.Now
            };
            var message3 = new Message
            {
                AuthorId = "1",
                Content = "3",
                Time = DateTime.Now
            };
            
            var chatController = new ChatController();

            chatController.CreateChat(chat);

            var chatFromDb = chatController.GetChat(1).Result;

            chatController.AddMessage("123", message1);

            chatFromDb.History.Add(message2);
            
            //Assert.AreEqual(chat.ChatId, chatFromDb.ChatId);
            /*CollectionAssert.AreEqual(chat.UserIds, chatFromDb.UserIds);
            CollectionAssert.AreEqual(chat.History, chatFromDb.History);*/
        }
        
    }
}