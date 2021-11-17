namespace University.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseModelAddUp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "CourseAssignTo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "CourseAssignTo");
        }
    }
}
