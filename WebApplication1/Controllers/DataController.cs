using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DataController : Controller
    {
    
        //For fetch Last Contact
        public JsonResult GetLastContact()
        {
            Contact c = null;
            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                c = dc.Contacts.OrderByDescending(a => a.ContactId).Take(1).FirstOrDefault();
            }
            return new JsonResult { Data = c, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult UserLogin(LoginData d)
        {
            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                var user = dc.Users.Where(a => a.Username.Equals(d.Username) && a.Password.Equals(d.Password)).FirstOrDefault();
                return new JsonResult { Data = user, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

        public JsonResult GetEmployeeList()
        {
            List<Employee> Employee = new List<Employee>();
            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                Employee = dc.Employees.OrderBy(a => a.FirstName).ToList();
            }

            return new JsonResult { Data = Employee, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


    }
}