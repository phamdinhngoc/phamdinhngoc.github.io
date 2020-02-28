using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using JQueryAjaxASP.NETMVC.Models;

namespace JQueryAjaxASP.NETMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewAll()
        {
            return View(GetAllEmployee());
          
        }
       IEnumerable<Employee> GetAllEmployee()
        {
            using (DBModel db = new DBModel())
            {
                return db.Employees.ToList<Employee>();
            }
        }

        public ActionResult AddOrEdit(int id=0)
        {
            Employee emp = new Employee();

            return View(emp);
        }
        [HttpPost]
        public ActionResult AddOrEdit()
        {
            return View();
        }
    }
}