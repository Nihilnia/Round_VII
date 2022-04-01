using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace warmUp.Models.Database
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(30)]
        public string OrderName { get; set; }
        public int HowMany { get; set; }
        public People People { get; set; }
    }
}