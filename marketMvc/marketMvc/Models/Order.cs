using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace marketMvc.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public double Quantity { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}