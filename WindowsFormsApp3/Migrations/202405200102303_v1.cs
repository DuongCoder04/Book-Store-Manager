namespace WindowsFormsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Staff_Id", "dbo.Staff");
            DropIndex("dbo.Books", new[] { "Staff_Id" });
            DropColumn("dbo.Books", "Staff_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Staff_Id", c => c.Int());
            CreateIndex("dbo.Books", "Staff_Id");
            AddForeignKey("dbo.Books", "Staff_Id", "dbo.Staff", "Id");
        }
    }
}
