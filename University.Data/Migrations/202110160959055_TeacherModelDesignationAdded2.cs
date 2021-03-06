namespace University.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeacherModelDesignationAdded2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Teachers", "DeptId");
            DropColumn("dbo.Teachers", "DesignId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "DesignId", c => c.Int(nullable: false));
            AddColumn("dbo.Teachers", "DeptId", c => c.Int(nullable: false));
        }
    }
}
