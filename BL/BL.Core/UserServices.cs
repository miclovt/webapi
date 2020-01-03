using System.Collections.Generic;
using System;
using dao;
using Dao.DB.Model;

namespace BL.Core
{
    public class UserServices
    {
        private static UserDB dB=new UserDB();

        public List<User> getUsers() => dB.getAllUsers<User>("user");

        public User getUser(string id)=>dB.getUserbyId<User>("user",id);

        public void addUser(string namex)=>dB.addUser<User>("user",new User{ name=namex } );

        public void deleteUser(string id)=>dB.delelteUser<User>("user",id);

    }
}
