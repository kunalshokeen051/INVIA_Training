namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String());
        }
    }
}
