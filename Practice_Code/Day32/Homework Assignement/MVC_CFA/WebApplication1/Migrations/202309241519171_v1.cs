namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Salary_Salary_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Salary_Salary_Id");
            AddForeignKey("dbo.Employees", "Salary_Salary_Id", "dbo.Salaries", "Salary_Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Salary_Salary_Id", "dbo.Salaries");
            DropIndex("dbo.Employees", new[] { "Salary_Salary_Id" });
            DropColumn("dbo.Employees", "Salary_Salary_Id");
        }
    }
}
