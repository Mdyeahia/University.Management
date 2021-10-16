namespace University.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeacherModelDesignationAdded1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "DeptId", c => c.Int(nullable: false));
            AddColumn("dbo.Teachers", "DesignId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "DesignId");
            DropColumn("dbo.Teachers", "DeptId");
        }
    }
}
