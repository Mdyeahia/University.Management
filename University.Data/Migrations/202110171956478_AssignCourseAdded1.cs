namespace University.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssignCourseAdded1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AssignCourses", "DepartId", c => c.Int(nullable: false));
            DropColumn("dbo.AssignCourses", "DeptId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AssignCourses", "DeptId", c => c.Int(nullable: false));
            DropColumn("dbo.AssignCourses", "DepartId");
        }
    }
}
