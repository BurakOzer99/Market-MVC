using marketMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;// buda eklediğimiz kütüphane
using System.Linq;
using System.Web;

namespace marketMvc.Entity
{
    public class DataContext:DbContext // burda database  ekliyorsun ve tablolarını oluşturuyorsun ve üste kütüphaneyi ekliyorsun
    {
        public DataContext() : base("MarketConnection") { }
        public DbSet <Customer> Customer { get; set; }
        public DbSet <Order> Order { get; set; }
        public DbSet <Product> Product { get; set; }
    }
}