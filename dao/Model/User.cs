using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Dao.DB.Model
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id{ get; set; }
        public string name{ get; set; }
    }
}