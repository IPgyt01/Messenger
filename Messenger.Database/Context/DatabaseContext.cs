﻿using MongoDB.Driver;

namespace Messenger.Database.Context
{
    public class DatabaseContext
    {
        /*переменная, которая подключает вас к хосту mongo*/
        private const string Host = "mongodb+srv://alexzonic:Flatronw22@cluster0.vvwvz.mongodb.net/MessengerDB?retryWrites=true&w=majority";

        // это будет именем базы данных, в которой хранятся коллекции
        private const string DbName = "MessengerDB";

        private readonly IMongoClient _client;
        protected IMongoDatabase Database { get; }

        protected DatabaseContext()
        {
            if (_client is null) // так client будет всего 1
            {
                _client = new MongoClient(Host);
                Database = _client.GetDatabase(DbName);
            }
        }
    }
}