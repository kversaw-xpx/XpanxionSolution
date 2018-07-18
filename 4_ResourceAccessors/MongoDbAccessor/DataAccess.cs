using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Xpanxion.Contracts;
using Xpanxion.DataContracts;
namespace DatabaseAccessor
{
    public class DataAccess<t> : IDataAccess<t> where t:BaseClass
    {
        protected IMongoClient _client;      
        protected IMongoDatabase _db;
        //protected IMongoCollection<t> _collection;
        protected string _collectionName;

        public DataAccess()
        {
            string databaseLocation = ConfigurationManager.AppSettings["MongoLocation"];
            string databaseName = ConfigurationManager.AppSettings["MongoDatabaseName"];
            _collectionName = typeof(t).ToString().Split('.').ToList().Last(); //we want to name the collection after the data contract name, not the whole namesapce
            _client = new MongoClient(databaseLocation);            
            _db = _client.GetDatabase(databaseName);     

        }    

        public IEnumerable<t> GetData()
        {
            return _db.GetCollection<t>(_collectionName).Find(f=>true).ToEnumerable<t>();
        }

        public void AddOneItem(t dataItem)
        {
            if(dataItem.Id==null)
            {
                //need to generate an id for the item
                dataItem.Id = ObjectId.GenerateNewId().ToString();
            }

            _db.GetCollection<t>(_collectionName).InsertOne(dataItem);
        }
    }
}
