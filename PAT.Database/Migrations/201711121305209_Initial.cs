namespace PAT.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
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
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmpId = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpId)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: false)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeRelationships", "PersonId", "dbo.People");
            DropForeignKey("dbo.EmployeeRelationships", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "PersonId", "dbo.People");
            DropIndex("dbo.Employees", new[] { "PersonId" });
            DropIndex("dbo.EmployeeRelationships", new[] { "PersonId" });
            DropIndex("dbo.EmployeeRelationships", new[] { "EmployeeId" });
            DropTable("dbo.People");
            DropTable("dbo.Employees");
            DropTable("dbo.EmployeeRelationships");
        }
    }
}
