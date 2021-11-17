namespace University.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelDecimalToDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AssignCourses", "CreditTaken", c => c.Double(nullable: false));
            AlterColumn("dbo.AssignCourses", "CreditRemain", c => c.Double(nullable: false));
            AlterColumn("dbo.AssignCourses", "CourseCredit", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AssignCourses", "CourseCredit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.AssignCourses", "CreditRemain", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.AssignCourses", "CreditTaken", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
