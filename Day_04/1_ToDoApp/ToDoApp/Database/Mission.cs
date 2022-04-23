using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoApp.Database
{
    public class Mission
    {
        public Mission()
        {
            this.Categories = new List<Category>();
        }

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public List<Category> Categories { get; set; }
    }
}