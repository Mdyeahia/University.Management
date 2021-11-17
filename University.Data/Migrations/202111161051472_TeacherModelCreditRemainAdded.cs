namespace University.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeacherModelCreditRemainAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "CreditTaken", c => c.Double(nullable: false));
            AddColumn("dbo.Teachers", "CreditRemain", c => c.Double(nullable: false));
            DropColumn("dbo.Teachers", "Credit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "Credit", c => c.Int(nullable: false));
            DropColumn("dbo.Teachers", "CreditRemain");
            DropColumn("dbo.Teachers", "CreditTaken");
        }
    }
}
