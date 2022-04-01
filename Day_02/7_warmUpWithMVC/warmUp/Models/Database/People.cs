using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace warmUp.Models.Database
{
    public class People
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(30)]
        public string UserName { get; set; }

        [MaxLength(30)]
        public string Password { get; set; }
        public bool isActive { get; set; }
        public List<Order> Orders { get; set; }
    }
}