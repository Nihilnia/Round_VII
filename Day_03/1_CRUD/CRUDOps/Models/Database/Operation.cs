using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDOps.Models.Database
{
    public class Operation
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(30), Required]
        public string Name { get; set; }
        public bool isActive { get; set; }
        public User User { get; set; }
    }
}