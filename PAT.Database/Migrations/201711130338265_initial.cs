namespace PAT.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dependents",
                c => new
                    {
                        DependantId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        IsSpouse = c.Boolean(nullable: false),
                        EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.DependantId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        WageId = c.Int(nullable: false),
                        DependantId = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Wages",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false),
                        BiWeeklyWage = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dependents", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Wages", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Wages", new[] { "EmployeeId" });
            DropIndex("dbo.Dependents", new[] { "EmployeeId" });
            DropTable("dbo.Wages");
            DropTable("dbo.Employees");
            DropTable("dbo.Dependents");
        }
    }
}
