using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLHelperDataAnnotation.Models;

namespace HTMLHelperDataAnnotation.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Create()
        {
            ViewBag.Departments = GetAllDepartments();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            ViewBag.Departments = GetAllDepartments();
            return View();
        }

        private List<Department> GetAllDepartments()
        {
            return new List<Department>()
            {
                new Department(){Id = "",Name = "Select..."},
                new Department(){Id = "1",Name = "HR"},
                new Department(){Id = "2",Name = "Accounts"},
                new Department(){Id = "3",Name = "IT"}
            };
        } 
	}
}