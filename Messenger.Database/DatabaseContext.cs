using Messenger.Database.Models;
using MongoDB.Driver;

namespace Messenger.Database
{
    public class DatabaseContext
    {
        /*временная переменная, которая подключает вас к локальному хосту mongo
         когда сервер будет в инете, значение поменяется*/ 
        private readonly string _host = "mongodb+srv://alexzonic:Flatronw22@cluster0.vvwvz.mongodb.net/MessengerDB?retryWrites=true&w=majority";

        // это будет именем базы данных, в которой хранятся коллекции
        private readonly string _dbName = "MessengerDB";
        
        private MongoClient _client;
        protected IMongoDatabase Database { get; }
            
        public DatabaseContext()
        {
            _client = new MongoClient(_host);
            Database = _client.GetDatabase(_dbName);
        }
    }
}