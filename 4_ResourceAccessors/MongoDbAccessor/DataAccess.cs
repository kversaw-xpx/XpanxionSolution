using MongoDB.Driver;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Xpanxion.Contracts;

namespace DatabaseAccessor
{
    public class DataAccess<t> :IDataAccess<t>
    {
        protected IMongoClient _client;      
        protected IMongoDatabase _db;
        protected IMongoCollection<t> _collection;
        protected string _collectionName;

        public DataAccess()
        {
            string databaseLocation = ConfigurationManager.AppSettings["MongoLocation"];
            string databaseName = ConfigurationManager.AppSettings["MongoDatabaseName"];
            _collectionName = typeof(t).ToString().Split('.').ToList().Last(); //we want to name the collection after the data contract name, not the whole namesapce
            _client = new MongoClient(databaseLocation);            
            _db = _client.GetDatabase(databaseName);
            _collection = _db.GetCollection<t>(_collectionName);
        }    

        public IEnumerable<t> GetData()
        {
            return _db.GetCollection<t>(_collectionName).Find(f=>true).ToEnumerable<t>();
        }

        public void AddOneItem(t dataItem)
        {
            _collection.InsertOne(dataItem);
        }
    }
}
