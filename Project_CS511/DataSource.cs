using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Project_CS511
{
    internal class DataSource
    {
        public IMongoDatabase data;
        public IMongoCollection<BsonDocument> collection;
        public DataSource()
        {
            MongoClient client = new MongoClient("mongodb+srv://nguyenvanlien3434:yAvV8Z5JnjSdDA7l@cluster0.xpedglx.mongodb.net/");
            data = client.GetDatabase("Database");
        }
        public void SetCollection(string collectionName)
        {
            collection = data.GetCollection<BsonDocument>(collectionName);
        }
        

        public List<BsonDocument> returnAllData()
        {
            if (collection != null)
            {
                return collection.Find(new BsonDocument()).ToList();
            }
            return new List<BsonDocument>();
        }
        #region Insert
        public void insertToCollection(BsonDocument document)
        {
            collection.InsertOneAsync(document);
        }

        public void addToAll(string newAtrr, string newValue)
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var update = Builders<BsonDocument>.Update.Set(newAtrr, newValue);
            var result = collection.UpdateMany(filter, update);
            Console.WriteLine($"Matched {result.MatchedCount} document(s) and modified {result.ModifiedCount} document(s).");
        }
        #endregion
        #region Filter Definition
        public bool checkLogIn(string name, string password)
        {
            var filter = Builders<BsonDocument>.Filter.And(
            Builders<BsonDocument>.Filter.Eq("name", name),
            Builders<BsonDocument>.Filter.Eq("password", password)
            );
            var result = collection.Find(filter).FirstOrDefault();
            return result != null;
        }


        #endregion
        #region FindData
        public string findValue(string findAttr, string findId, string attr)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(findAttr, findId);
            var result = collection.Find(filter).FirstOrDefault();
            if (result != null)
                return result.GetValue(attr, "").AsString;
            else
                return "";

        }

        public List<BsonDocument> findMultipleDoc(string findAttr, string findValue)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(findAttr, findValue);
            var result = collection.Find(filter);
            return result.ToList();
        }

        public BsonDocument findOneDoc(string findAttr, string findValue)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(findAttr, findValue);
            var result = collection.Find(filter).FirstOrDefault();
            return result;
        }

        

        #endregion
        #region Update


        public void findAndReplaceOne(string findAttr, string findValue, string replaceAtrr, string replaceValue)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(findAttr, findValue);
            var update = Builders<BsonDocument>.Update.Set(replaceAtrr, replaceValue);
            var result = collection.UpdateOne(filter, update);

        }

        public void findAndReplaceMany(string findAttr, string findValue, string replaceAtrr, string replaceValue)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(findAttr, findValue);
            var update = Builders<BsonDocument>.Update.Set(replaceAtrr, replaceValue);
            var result = collection.UpdateMany(filter, update);

        }


        #endregion
    }
}

