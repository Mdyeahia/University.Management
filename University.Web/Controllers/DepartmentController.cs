using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University.Entities;
using University.Service;
using University.Web.ViewModels;

namespace University.Web.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            DepartmentViewModel model = new DepartmentViewModel();

            model.departments = DepartmentService.Instance.AllDepartments();

            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Department dept)
        {
            var newDept = new Department();
            newDept.Code = dept.Code;
            newDept.Name = dept.Name;

            DepartmentService.Instance.SaveDept(newDept);
            return RedirectToAction("Index");
        }
    }
}