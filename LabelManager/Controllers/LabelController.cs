using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabelManager.Models;
using LabelManager.ViewModels;

namespace LabelManager.Controllers
{
    public class LabelController : Controller
    {
        //GET: Label/Index
        public ActionResult Index()
        {
            var label = new Label() { Address = "74 N Hanley Ave, Apt A \nBozeman, MT 59718" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer One" },
                new Customer { Name = "Customer Two" }
            };

            var viewModel = new CustomerOrderViewModel
            {
                Label = label,
                Customers = customers
            };
            return View(viewModel);

            //return View(label); 
            //For redirect: first argument is action name, second is controller, third is anonymous object to pass arguments to target action
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });

        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }
           
        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy ));
        //}

        [Route("label/customer/{customerName:maxlength(20)}/{orderId:regex(\\d{6}):range(120000, 999999)}")]
        public ActionResult ByCustomer(string customerName, int orderId)
        {
            return Content(customerName + "/" + orderId);
        }
    }
}

