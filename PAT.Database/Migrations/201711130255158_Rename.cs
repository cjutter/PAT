namespace PAT.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rename : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Dependants", newName: "Dependents");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Dependents", newName: "Dependants");
        }
    }
}
