using Session_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session_Demo.Controllers
{
    public class SessionDemoController : Controller
    {
        [HttpGet]
        public ActionResult Demo()
        {
            List<Employee> employees1 = Employees();
            Session["MyDatatble"] = employees1;


            ViewBag.Emp = (List<Employee>)Session["MyDatatble"];
            return View();
        }
        [HttpPost]
        public ActionResult Demo(string tb)
        {
            //List<Employee> employees1 = Employees();
            ViewBag.Emp = (List<Employee>)Session["MyDatatble"];

            ViewBag.Message = "Employee Saved";
            return View();
        }
        public List<Employee> Employees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Name = "Rafiq",Des = "IT"},
                new Employee(){Name = "jaman",Des = "IT"},
            };
            return employees;
        }
    }
}