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
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            TeacherListingViewModel model = new TeacherListingViewModel();
            model.teachers = TeacherService.Instance.GetAllTeacher();
            return View(model);
        }
        public ActionResult Create()
        {
            TeacherViewModelCreate model = new TeacherViewModelCreate();

            model.departments = DepartmentService.Instance.AllDepartments();
            model.designations = CodeService.Instance.GetAllDesignation();

            return View(model);
        }
        [HttpPost]
        public ActionResult Create(TeacherViewModelCreate model)
        {
            var newTeacher = new Teacher();

            newTeacher.Name = model.Name;
            newTeacher.Address = model.Address;
            newTeacher.Email = model.Email;
            newTeacher.Contact = model.Contact;
            newTeacher.Credit = model.Credit;
            newTeacher.Designation = CodeService.Instance.GetDesignById(model.DesignId);
            newTeacher.Department = DepartmentService.Instance.GetDepartbyId(model.DeptId);

            TeacherService.Instance.SaveTeacher(newTeacher);

            return RedirectToAction("Index");
        }

    }
}