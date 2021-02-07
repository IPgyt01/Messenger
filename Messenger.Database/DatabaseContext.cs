using MongoDB.Driver;

namespace Messenger.Database
{
    public class DatabaseContext
    {
        /*временная переменная, которая подключает вас к локальному хосту mongo
         когда сервер будет в инете, значение поменяется*/ 
        private readonly string _host = "mongodb://localhost:27017";

        // это будет именем базы данных, в которой хранятся коллекции
        private readonly string _dbName = "Messenger";
        
        private MongoClient _client;
        public IMongoDatabase Database { get; }
            
        public DatabaseContext()
        {
            _client = new MongoClient(_host);
            Database = _client.GetDatabase(_dbName);
        }
    }
}