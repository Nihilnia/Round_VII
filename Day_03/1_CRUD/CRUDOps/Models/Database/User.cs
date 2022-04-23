using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDOps.Models.Database
{
    public class User
    {

        [Key]
        public int ID { get; set; }

        [MaxLength(30), Required]
        public string UserName { get; set; }

        [MaxLength(30), Required]
        public string Password { get; set; }
        public List<Operation> Operations { get; set; }
    }
}