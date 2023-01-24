using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace marketMvc.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public double Balance { get; set; } // balance = bakiye demek
        public List<Order> Order { get; set; }


    }
}