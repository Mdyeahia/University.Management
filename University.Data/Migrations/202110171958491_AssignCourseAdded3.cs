namespace University.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssignCourseAdded3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AssignCourses", "Department_Id", "dbo.Departments");
            DropIndex("dbo.AssignCourses", new[] { "Department_Id" });
            RenameColumn(table: "dbo.AssignCourses", name: "Department_Id", newName: "DepartmentId");
            AlterColumn("dbo.AssignCourses", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.AssignCourses", "DepartmentId");
            AddForeignKey("dbo.AssignCourses", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
            DropColumn("dbo.AssignCourses", "DepartId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AssignCourses", "DepartId", c => c.Int(nullable: false));
            DropForeignKey("dbo.AssignCourses", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.AssignCourses", new[] { "DepartmentId" });
            AlterColumn("dbo.AssignCourses", "DepartmentId", c => c.Int());
            RenameColumn(table: "dbo.AssignCourses", name: "DepartmentId", newName: "Department_Id");
            CreateIndex("dbo.AssignCourses", "Department_Id");
            AddForeignKey("dbo.AssignCourses", "Department_Id", "dbo.Departments", "Id");
        }
    }
}
