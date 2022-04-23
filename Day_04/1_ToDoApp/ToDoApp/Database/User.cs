using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoApp.Database
{
    public class User
    {
        public User()
        {
            this.Missions = new List<Mission>();
            this.Categories = new List<Category>();
        }


        [Key]
        public int ID { get; set; }

        [MaxLength(30), Required]
        public string UserName { get; set; }

        [MaxLength(30), Required]
        public string Password { get; set; }
        public List<Mission> Missions { get; set; }
        public List<Category> Categories { get; set; }
    }
}