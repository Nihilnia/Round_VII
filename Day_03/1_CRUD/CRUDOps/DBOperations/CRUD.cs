using CRUDOps.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDOps.DBOperations
{
    public static class CRUD
    {
        //ADD NEW USER
        public static bool addUser(User incomingUser)
        {
            bool result = false;

            using (var DB = new AprilContext())
            {
                User newUser = new User()
                {
                    UserName = incomingUser.UserName,
                    Password = incomingUser.Password,
                };

                DB.Users.Add(newUser);
                DB.SaveChanges();

                //every time, every time..
                result = true;
            } 

            return result;
        }


        //GET AN USER
        public static User getUser(User incomingUser)
        {

            User findUser = new User();


            using (var DB = new AprilContext())
            {
                User theUser = DB.Users.Where(f => f.UserName == incomingUser.UserName).FirstOrDefault();

                if (findUser != null)
                {
                    findUser = theUser;
                }
            }

            return findUser;
        }


        //GET ALL USERS
        public static List<User> getAllUsers()
        {
            var allUsers = new List<User>();

            using (var DB = new AprilContext())
            {
                allUsers = DB.Users.ToList();
            }

            //check here
            return allUsers;
        }


        //UPDATE AN USER
        public static int updateUser(User incomingUser, User newUserInfos)
        {
            //0- user not found
            //1- user found and updated
            //2- somethings went wrong

            int result = 0;


            using (var DB = new AprilContext())
            {
                User findUser = DB.Users.Where(f => f.UserName == incomingUser.UserName).FirstOrDefault();

                if (findUser != null)
                {
                    findUser.UserName = newUserInfos.UserName;
                    findUser.Password = newUserInfos.Password;

                    DB.SaveChanges();
                    result = 1;
                }

                
            }

            return result;
        }


        //UPDATE- GLORIA
        public static int GLORIA()
        {
            int resultat = 0;

            using (var DB = new AprilContext())
            {
                List<User> allUsers = DB.Users.ToList();

                for (int f = 0; f <= allUsers.Count; f++)
                {
                    allUsers[f].UserName = "GLORIA_" + (f + 1);
                    allUsers[f].Password = allUsers[f].Password + "_" + (f + 1);
                    
                    DB.SaveChanges();

                    //check here

                    resultat = 1;
                }
            }

            return resultat;
        }
    }
}