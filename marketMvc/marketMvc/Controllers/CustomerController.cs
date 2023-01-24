using marketMvc.Entity;
using marketMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace marketMvc.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        DataContext db = new DataContext();
        public ActionResult Index()
        {
            List<Customer> listCostemer = db.Customer.ToList();
            return View(listCostemer);
        }
        [HttpGet]
        public ActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            db.Customer.Add(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id )
        {
            Customer customer = db.Customer.Find(id);
            if (customer==null)
            {
                return RedirectToAction("Index");
            }
            
                return View(customer);
        }
        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            Customer newcustomer = db.Customer.Find(customer.Id);
            newcustomer.Name = customer.Name;
            newcustomer.SurName = customer.SurName;
            newcustomer.Balance = customer.Balance;
            db.SaveChanges();
                return RedirectToAction("Index");

        }
     
        public ActionResult Delete(int id)
        {
            Customer newcustomer = db.Customer.Find(id);
            db.Customer.Remove(newcustomer);
            db.SaveChanges();
            return RedirectToAction("Index");  
        }

    }
}