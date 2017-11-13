namespace PAT.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nowageid : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "WageId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "WageId", c => c.Int(nullable: false));
        }
    }
}
