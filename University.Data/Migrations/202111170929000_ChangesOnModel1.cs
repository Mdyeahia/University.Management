namespace University.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesOnModel1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AssignCourse", newName: "AssignCourses");
            RenameTable(name: "dbo.Course", newName: "Courses");
            RenameTable(name: "dbo.Department", newName: "Departments");
            RenameTable(name: "dbo.Teacher", newName: "Teachers");
            RenameTable(name: "dbo.Designation", newName: "Designations");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Designations", newName: "Designation");
            RenameTable(name: "dbo.Teachers", newName: "Teacher");
            RenameTable(name: "dbo.Departments", newName: "Department");
            RenameTable(name: "dbo.Courses", newName: "Course");
            RenameTable(name: "dbo.AssignCourses", newName: "AssignCourse");
        }
    }
}
