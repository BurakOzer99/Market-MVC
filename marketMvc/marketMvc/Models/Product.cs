using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace marketMvc.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stok { get; set; }
        public List<Order> Order { get; set; }
    }
}