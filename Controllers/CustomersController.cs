using RentVids.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentVids.Controllers
{
    
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer {Id = 1, Name="Jilo" },
            new Customer {Id = 2, Name="Kimuntu" },
            new Customer {Id = 3, Name="Yann" }
        };
        // GET: Customers
        public ActionResult Index()
        {

            return View(customers);
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            return View(customers.Where(c => c.Id == id).FirstOrDefault());
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
