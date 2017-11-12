namespace PAT.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeRelationship1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeRelationships",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                        RelationshipType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmployeeId, t.PersonId })
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: false)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: false)
                .Index(t => t.EmployeeId)
                .Index(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeRelationships", "PersonId", "dbo.People");
            DropForeignKey("dbo.EmployeeRelationships", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.EmployeeRelationships", new[] { "PersonId" });
            DropIndex("dbo.EmployeeRelationships", new[] { "EmployeeId" });
            DropTable("dbo.EmployeeRelationships");
        }
    }
}
