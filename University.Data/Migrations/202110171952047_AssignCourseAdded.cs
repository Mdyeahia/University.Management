namespace University.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssignCourseAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssignCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeptId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                        CreditTaken = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreditRemain = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CourseId = c.Int(nullable: false),
                        CourseName = c.String(),
                        CourseCredit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .ForeignKey("dbo.Teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId)
                .Index(t => t.CourseId)
                .Index(t => t.Department_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AssignCourses", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.AssignCourses", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.AssignCourses", "CourseId", "dbo.Courses");
            DropIndex("dbo.AssignCourses", new[] { "Department_Id" });
            DropIndex("dbo.AssignCourses", new[] { "CourseId" });
            DropIndex("dbo.AssignCourses", new[] { "TeacherId" });
            DropTable("dbo.AssignCourses");
        }
    }
}
