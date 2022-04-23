using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoApp.Database;
using ToDoApp.Models;

namespace ToDoApp.CRUD
{
    public static class Operations
    {
        //NEW USER REGISTRATION
        public static User Register(User incomingUser)
        {
            User daUser = new User();

            using (var DB = new ToDoExerciseContext())
            {
                User newUser = new User()
                {
                    UserName = incomingUser.UserName,
                    Password = incomingUser.Password,
                };

                DB.Users.Add(newUser);
                DB.SaveChanges();

                daUser = newUser;
            }

            return daUser;
        }


        //USER LOGIN- CONTROL
        public static User LoginControl(User incomingUser)
        {
            User resultat = null;

            using (var DB = new ToDoExerciseContext())
            {
                User findUser = DB.Users.Where(f => f.UserName == incomingUser.UserName).FirstOrDefault();

                if (findUser != null)
                {
                    if (findUser.Password == incomingUser.Password)
                    {
                        resultat = findUser;
                    }
                }
            }

            return resultat;
        }


        //ADDING NEW MISSIONS
        public static User AddMission(AddingMissionModel incomingModel)
        {
            var resultat = new User();

            using (var DB = new ToDoExerciseContext())
            {
                var findUser = DB.Users.Where(f => f.UserName == incomingModel.UserName).FirstOrDefault();

                if (findUser != null)
                {
                    var newMission = new Mission()
                    {
                        Name = incomingModel.MissionName
                    };

                    var newCategory = new Category()
                    {
                        Name = incomingModel.CategoryName
                    };


                    findUser.Missions.Add(newMission);
                    findUser.Categories.Add(newCategory);

                    DB.SaveChanges();


                    resultat = findUser;
                }
            }

            return resultat;
        }
    }
}