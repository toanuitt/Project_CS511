using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Project_CS511
{
    public class DataSource
    {
        public IMongoDatabase data;
        public IMongoCollection<BsonDocument> collection;
        public DataSource()
        {
            MongoClient client = new MongoClient("mongodb+srv://nguyenvanlien3434:miFKzNkYFGBv2oSD@cluster0.xpedglx.mongodb.net/");
            data = client.GetDatabase("Database");
        }
        public void SetCollection(string collectionName)
        {
            collection = data.GetCollection<BsonDocument>(collectionName);
        }
        
        //Hàm này trả về tất cả dữ liệu trong một collection dưới dạng một list chứa các BsonDocumment
        public List<BsonDocument> returnAllData()
        {
            if (collection != null)
            {
                return collection.Find(new BsonDocument()).ToList();
            }
            return new List<BsonDocument>();
        }

        //Hàm này trả về chiều dài của collection
        public int getLength()
        {
            if (collection != null)
            {
                return collection.Find(new BsonDocument()).ToList().Count;
            }
            return 0;
        }

        #region Insert Data
        //Hàm này dùng để thêm một BsonDocument vào trong collection
        public void insertToCollection(BsonDocument document)
        {
            collection.InsertOneAsync(document);
        }

        //Hàm này dùng để thêm một thuộc tính vào tất cả BsonDocumment trong collection
        /*
            VD Ta có một BsonDoc như sau:
            {
                "pet": "cat",
                "age": "10"
            }
            Thêm thuộc tính "adopted" với giá trị "true" vào tất cả documment trong collection
            data.addToAll("adopted", "true")
            Kết quả:
            {
                "pet": "cat",
                "age": "10",
                "adopted": "true"
            }
         */
        public void addToAll(string newAtrr, string newValue)
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var update = Builders<BsonDocument>.Update.Set(newAtrr, newValue);
            var result = collection.UpdateMany(filter, update);
            Console.WriteLine($"Matched {result.MatchedCount} document(s) and modified {result.ModifiedCount} document(s).");
        }
        #endregion
        #region Filter Data
        public bool checkLogIn(string name, string password)
        {
            var filter = Builders<BsonDocument>.Filter.And(
            Builders<BsonDocument>.Filter.Eq("loginName", name),
            Builders<BsonDocument>.Filter.Eq("password", password)
            );
            var result = collection.Find(filter).FirstOrDefault();
            return result != null;
        }


        #endregion

        #region Find Data
        //Tìm giá trị một thuộc tính của một document trong collection
        /*
            VD:
            {
              "userType": "shop",
              "username": "Quán Trà Sữa Taca",
              "email": "taca@example.com",
              "password": "taca",
              "location": "",
              "userId": "1"
            }
        Lấy giá trị thuộc tính username của document có "userId" là "1"
        data.findValue("userId", "1", "username")
        ->  giá trị trả về: "Quán Trà Sữa Taca"
        */
        public string findValue(string findAttr, string findValue, string needAttr)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(findAttr, findValue);
            var result = collection.Find(filter).FirstOrDefault();
            if (result != null)
                return result.GetValue(needAttr, "").AsString;
            else
                return "";

        }

        //Tìm nhiều documment thỏa mãn một điều kiện nhất định và trả về một list chứa các doc thỏa diều kiện
        /*
            {
              "userType": "shop",
              "username": "Quán Trà Sữa Taca",
              "email": "taca@example.com",
              "password": "taca",
              "location": "",
              "userId": "1"
            }
            VD: Tìm tất cả document có "userType" là "shop"
            data.findMultipleDoc("userType", "shop")
         */
        public List<BsonDocument> findMultipleDoc(string findAttr, string findValue)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(findAttr, findValue);
            var result = collection.Find(filter);
            return result.ToList();
        }

        //Giống trên nhưng chỉ trả về document đầu tiên tìm thấy
        public BsonDocument findOneDoc(string findAttr, string findValue)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(findAttr, findValue);
            var result = collection.Find(filter).FirstOrDefault();
            return result;
        }

        //Lấy ra một document ngẫu nhiên
        public BsonDocument getRandomDoc()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, getLength() + 1);

            var randDocument = collection.Find(FilterDefinition<BsonDocument>.Empty)
                                   .Skip(randomNumber - 1) 
                                   .Limit(1)
                                   .FirstOrDefault();
            return randDocument;
        }

        public List<BsonDocument> findWithFilter(FilterDefinition<BsonDocument> filter)
        {
            var result = collection.Find(filter).ToList();
            return result;
        }

        public List<string> getAttributeValues( string attributeName)
        {
            // Create a filter to retrieve all documents
            var filter = Builders<BsonDocument>.Filter.Empty;

            // Project the specified attribute
            var projection = Builders<BsonDocument>.Projection.Include(attributeName);

            // Execute the find operation with the specified filter and projection
            var cursor = collection.Find(filter).Project(projection).ToCursor();

            // Create a list to store the attribute values
            List<string> attributeValues = new List<string>();

            // Iterate through the cursor and extract the attribute values
            foreach (var document in cursor.ToEnumerable())
            {
                if (document.Contains(attributeName))
                {
                    attributeValues.Add(document[attributeName].AsString);
                }
                else
                {
                    // Handle cases where the attribute is missing in a document
                    attributeValues.Add("N/A");
                }
            }

            return attributeValues;
        }
        #endregion
        #region Update

        //Tìm MỘT documment thỏa mãn một điều kiện nhất định và cập nhật một thuộc tính
        /*
            {
              "userType": "shop",
              "username": "Quán Trà Sữa Taca",
              "email": "taca@example.com",
              "password": "taca",
              "location": "",
              "userId": "1"
            }
            VD: Tìm document đầu tiên có "userType" là "shop" là thay "location" bằng "Ho Chi Minh City" 
            data.findAndReplaceOne("userType", "shop", "location", "Ho Chi Minh City")
            -> Kết quả:
            {
              "userType": "shop",
              "username": "Quán Trà Sữa Taca",
              "email": "taca@example.com",
              "password": "taca",
              "location": "Ho Chi Minh City",
              "userId": "1"
            }
         */
        public void findAndReplaceOne(string findAttr, string findValue, string replaceAtrr, string replaceValue)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(findAttr, findValue);
            var update = Builders<BsonDocument>.Update.Set(replaceAtrr, replaceValue);
            var result = collection.UpdateOne(filter, update);

        }
        //Giống trên nhưng thay toàn bộ các document thỏa điều kiện
        public void findAndReplaceMany(string findAttr, string findValue, string replaceAtrr, string replaceValue)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(findAttr, findValue);
            var update = Builders<BsonDocument>.Update.Set(replaceAtrr, replaceValue);
            var result = collection.UpdateMany(filter, update);

        }

        #endregion

        public void deleteOneByValue(string attr, string value)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(attr, value);
            var result = collection.DeleteOne(filter);
            var num = result.DeletedCount;
        }

        public void deleteManyByValue(string attr, string value)
        {
            var filter = Builders<BsonDocument>.Filter.Eq(attr, value);
            collection.DeleteMany(filter);
        }

        public void deleteAll()
        {
            collection.DeleteMany(FilterDefinition<BsonDocument>.Empty);
        }

        #region Cac Ham chuc nang
        public BsonArray ConvertToBsonArray(string jsonString)
        {
            // Parse the string into a BsonDocument
            BsonDocument bsonDocument = BsonDocument.Parse(jsonString);

            // Extract the BsonArray from the document
            BsonArray bsonArray = bsonDocument["0"].AsBsonArray;

            return bsonArray;
        }
        #endregion
    }
}

