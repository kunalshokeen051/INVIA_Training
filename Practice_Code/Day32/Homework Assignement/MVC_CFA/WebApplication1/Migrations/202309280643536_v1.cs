namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Employee_Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 15),
                        Age = c.Int(nullable: false),
                        Department = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Salary_Salary_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Employee_Id)
                .ForeignKey("dbo.Salaries", t => t.Salary_Salary_Id)
                .Index(t => t.Salary_Salary_Id);
            
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        Salary_Id = c.Int(nullable: false, identity: true),
                        CTC = c.Long(nullable: false),
                        Basic_Pay = c.Long(nullable: false),
                        ESIC = c.Int(nullable: false),
                        EPF = c.Int(nullable: false),
                        Allowance = c.Int(nullable: false),
                        Bonus = c.Int(nullable: false),
                        Income_Tax = c.Int(nullable: false),
                        Mis_Deductions = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Salary_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Salary_Salary_Id", "dbo.Salaries");
            DropIndex("dbo.Employees", new[] { "Salary_Salary_Id" });
            DropTable("dbo.Salaries");
            DropTable("dbo.Employees");
        }
    }
}
