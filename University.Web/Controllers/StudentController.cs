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
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            ViewBag.departmentList = DepartmentService.Instance.AllDepartments();

            return View();
        }
        [HttpPost]
        public ActionResult Register(Student model)
        {
            if (ModelState.IsValid)
            {
                var newStudent = new Student();

                newStudent.Name = model.Name;
                if (IsEmailExists(model.Email) == false)
                {
                    newStudent.Email = model.Email;


                    newStudent.ContactNo = model.ContactNo;
                    if (model.Date != null)
                    {
                        newStudent.Date = model.Date;
                    }
                    else
                    {
                        newStudent.Date = DateTime.Now;
                    }

                    newStudent.Address = model.Address;
                    newStudent.DepartmentId = model.DepartmentId;
                    newStudent.StudentRegNo = StudentService.Instance.StudentRegNumber(model);

                    StudentService.Instance.SaveRegistration(newStudent);

                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("Email", "Email address already exists. Please enter a different email address.");
                    
                }
            }
            return View("Register");
        }
        public bool IsEmailExists(string Email)
        {


            return StudentService.Instance.EmailExist(Email);
        }
    }
}