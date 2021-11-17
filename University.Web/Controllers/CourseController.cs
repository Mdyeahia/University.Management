using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University.Entities;
using University.Entities.Code;
using University.Service;
using University.Web.ViewModels;

namespace University.Web.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            CoursListingViewModel model = new CoursListingViewModel();
            model.courses = CourseService.Instance.AllCourses();
            return View(model);
        }
        public ActionResult Create()
        {
            CourseViewmodelsCreate model = new CourseViewmodelsCreate();

            model.departments = DepartmentService.Instance.AllDepartments();

            model.semesters= Enum.GetValues(typeof(Semester))
                            .Cast<Semester>()
                            .ToList();

            return View(model);
        }
        [HttpPost]
        public ActionResult Create(CourseViewmodelsCreate model)
        {
            var newcourse = new Course();

            newcourse.Code = model.Code;
            newcourse.Name = model.Name;
            newcourse.Credit = model.Credit;
            newcourse.Description = model.Description;

            newcourse.DepartmentId = model.DeptId;
            newcourse.Semester = (Semester)Enum.Parse(typeof(Semester), model.semester.ToString());

            CourseService.Instance.SaveCourse(newcourse);

            return RedirectToAction("Index");
        }
    }
}