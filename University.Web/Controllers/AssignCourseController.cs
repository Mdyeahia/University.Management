﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University.Entities;
using University.Service;
using University.Web.ViewModels;

namespace University.Web.Controllers
{
    public class AssignCourseController : Controller
    {
        // GET: AssignCourse
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {

            ViewBag.DepartmentList = DepartmentService.Instance.AllDepartments();
            

            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,DepartmentId,TeacherId,CreditTaken,CreditRemain,CourseId,CourseName,CourseCredit")] AssignCourse assignCourse)
        {
            if (ModelState.IsValid)
            {
                AssignCourseService.Instance.SaveAssignCourse(assignCourse);
                
                ViewBag.Message = "Course Assigned Successful";

                //  return RedirectToAction("Index");
            }

            ViewBag.CourseID = new SelectList(CourseService.Instance.AllCourses(), "Id", "Code", assignCourse.CourseId);
            ViewBag.DepartmentId = new SelectList(DepartmentService.Instance.AllDepartments(), "Id", "Code", assignCourse.DepartmentId);
            ViewBag.TeacherId = new SelectList(TeacherService.Instance.GetAllTeacher(), "Id", "Name", assignCourse.TeacherId);
            return View(assignCourse);
        }
        public JsonResult TeacherByDepartmentId(int? DeptId)
        {
            var teachers = AssignCourseService.Instance.GetTeacherbydeptId((int)DeptId);
            return Json(teachers, JsonRequestBehavior.AllowGet);
        }
        public JsonResult CourseByDepartmentId(int? DeptId)
        {
            var courses = AssignCourseService.Instance.GetCbydId((int)DeptId);
            return Json(courses, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetTeacherById(int? teacherId)
        {
            var teacher = AssignCourseService.Instance.TeacherById((int)teacherId);
            return Json(teacher, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCourseById(int? CourseId)
        {
            var course = AssignCourseService.Instance.CourseById((int)CourseId);
            return Json(course, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult Create(AssignCourseFillterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var assignCourse = new AssignCourse();

                assignCourse.DepartmentId = model.DepartmentId;
                assignCourse.TeacherId = model.TeacherId;
                assignCourse.CreditTaken = model.CreditTaken;
                assignCourse.CreditRemain = model.CreditRemain;
                assignCourse.Course = CourseService.Instance.GetCourseById(model.CourseId);
                assignCourse.CourseName = model.CourseName;
                assignCourse.CourseCredit = model.CourseCredit;

                AssignCourseService.Instance.SaveAssignCourse(assignCourse);

                if (assignCourse.Teacher != null)
                {
                    var teacher = TeacherService.Instance.GetTeacherById(assignCourse.TeacherId);
                    teacher.CreditRemain = teacher.CreditTaken - assignCourse.CourseCredit;

                    TeacherService.Instance.UpdateTeacher(teacher);
                }
            }

            return RedirectToAction("Index");
        }
    }
}