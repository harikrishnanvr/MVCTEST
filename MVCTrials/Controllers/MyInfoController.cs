using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTrials.Controllers
{
    public class MyInfoController : Controller
    {
       public ActionResult MyInfo()
       {
            Models.Customer objCustomer = new Models.Customer();
            objCustomer.Name = "Hari";
            objCustomer.Age = 28;
            objCustomer.Nationality = "India";

            return View("MyInfo",objCustomer);
       }
        
    }
}