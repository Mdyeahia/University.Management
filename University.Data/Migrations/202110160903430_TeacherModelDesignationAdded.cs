namespace University.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeacherModelDesignationAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Contact = c.String(),
                        Credit = c.Int(nullable: false),
                        Department_Id = c.Int(),
                        Designation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .ForeignKey("dbo.Designations", t => t.Designation_Id)
                .Index(t => t.Department_Id)
                .Index(t => t.Designation_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "Designation_Id", "dbo.Designations");
            DropForeignKey("dbo.Teachers", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Teachers", new[] { "Designation_Id" });
            DropIndex("dbo.Teachers", new[] { "Department_Id" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Designations");
        }
    }
}
