using System.Collections;
using System.Collections.Generic;
using MongoDB.Driver;
using UnityEngine;
using MongoDB.Bson;
using System.Threading.Tasks;

public class DatabaseAcces : MonoBehaviour
{

    MongoClient client = new MongoClient("mongodb+srv://TFG:TFGPASSWORD@cluster0.2hgtgya.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
    IMongoDatabase database;
    IMongoCollection<BsonDocument> collection;

    void Start()
    {
        database = client.GetDatabase("tfgDB");
        collection = database.GetCollection<BsonDocument>("UserData");
    }

    public void SaveDataToDataBase(string name, string surname, string age, string email, string password, int range, int speed, int time)
    {
        var document = new BsonDocument
        {
            {"name", name},
            {"surname", surname},
            {"age", age},
            {"email", email} ,
            {"password", password},
            {"range", range },
            {"speed", speed },
            {"time", time }
        };
        collection.InsertOneAsync(document);
    }
    public async Task<bool> IsEmailRegisteredAsync(string email)
    {
        var filter = Builders<BsonDocument>.Filter.Eq("email", email);
        var result = await collection.Find(filter).FirstOrDefaultAsync();
        return result != null;
    }
    public async Task<bool> IsUserRegisteredAsync(string email, string password)
    {
        var filter = Builders<BsonDocument>.Filter.Eq("email", email) & Builders<BsonDocument>.Filter.Eq("password", password);
        var result = await collection.Find(filter).FirstOrDefaultAsync();
        return result != null;
    }

}
