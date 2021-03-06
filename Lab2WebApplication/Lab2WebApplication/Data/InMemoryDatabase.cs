﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab2WebApplication.Data.Entities;

namespace Lab2WebApplication.Data
{
    public class InMemoryDatabase
    {
        public static List<User> Users = new List<User>();
        public static int id = 0;

        public static int NextId()
        {
            return id++;
        }

        public static void DeleteUser(int id)
        {
            var user = Users.Find(u => u.Id == id);
            Users.Remove(user);
        }
    }
}