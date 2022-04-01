using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using warmUp.Models.Database;

namespace warmUp.Models.Operations
{
    public static class CRUD
    {
        public static bool AddPeople(People incomingPeople)
        {
            var resultat = false;

            var newPpl = new People()
            {
                UserName = incomingPeople.UserName,
                Password = incomingPeople.Password,
                isActive = incomingPeople.isActive
            };

            using (var DB = new NoWhereShopContext())
            {
                DB.Peoples.Add(newPpl);
                DB.SaveChanges();

                resultat = true;
            }

            return resultat;
            
        }

        public static List<People> GetPeople()
        {
            var daPeople = new List<People>();

            using (var DB = new NoWhereShopContext())
            {
                daPeople = DB.Peoples.ToList();
            }

            return daPeople;
        }
    }
}