namespace userManagment_Security.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoginViewModels",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LoginViewModels");
        }
    }
}
