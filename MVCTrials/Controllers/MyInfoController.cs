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
            //first method
            //Models.Customer objCustomer = new Models.Customer();
            //objCustomer.Name = "Hari";
            //objCustomer.Age = 28;
            //objCustomer.Nationality = "India";

            //return View("MyInfo", objCustomer);


            Models.Customer objCustomer = new Models.Customer();
            objCustomer.Name = "Hari";
            objCustomer.Age = 28;
            objCustomer.Nationality = "India";

            Models.Customer objCustomer1 = new Models.Customer
            {
                Name = "Anna",
                Age = 27,
                Nationality = "India"
            };
            
        
            

            List<Models.Customer> lscustomer = new List<Models.Customer>();
            lscustomer.Add(objCustomer);
            lscustomer.Add(objCustomer1);
            return View("MyInfoMultiple", lscustomer);

        }

    }
}