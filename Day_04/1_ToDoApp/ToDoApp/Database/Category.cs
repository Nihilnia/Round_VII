using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoApp.Database
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(30), Required]
        public string Name { get; set; }
        public Mission Mission { get; set; }
        public int MissionID { get; set; }
        
    }
}