namespace University.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesOnModel : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AssignCourses", newName: "AssignCourse");
            RenameTable(name: "dbo.Courses", newName: "Course");
            RenameTable(name: "dbo.Departments", newName: "Department");
            RenameTable(name: "dbo.Teachers", newName: "Teacher");
            RenameTable(name: "dbo.Designations", newName: "Designation");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Designation", newName: "Designations");
            RenameTable(name: "dbo.Teacher", newName: "Teachers");
            RenameTable(name: "dbo.Department", newName: "Departments");
            RenameTable(name: "dbo.Course", newName: "Courses");
            RenameTable(name: "dbo.AssignCourse", newName: "AssignCourses");
        }
    }
}
