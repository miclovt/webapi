using System.Data.Common;
using System;
using System.Collections.Generic;
using Dao.DB.Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace dao
{
    public class UserDB
    {
        private static IMongoDatabase database;

        public UserDB()
        {
            MongoClient client=new MongoClient();
            database=client.GetDatabase("base_de_datos_chida");
        }

        public List<User> getAllUsers<User>(string collection)
        {
            return database.GetCollection<User>(collection).Find(new BsonDocument()).ToList();
        }

        public void addUser<T>(string collection,T user)
        {
            database.GetCollection<T>(collection).InsertOne(user);
        }

        public User getUserbyId<User>(string collection,string id)
        {
            var filter=Builders<User>.Filter.Eq("id",id);
            return database.GetCollection<User>(collection).Find(filter).First();
        }

        public void delelteUser<User>(string collection,string id)
        {
            var filter=Builders<User>.Filter.Eq("id",id);
            database.GetCollection<User>(collection).DeleteOne(filter);
        }
    }
}
