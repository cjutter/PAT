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
                        DependentEmployeeId = c.Int(),
                        DependentEmployee_EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.DependantId)
                .ForeignKey("dbo.Employees", t => t.DependentEmployee_EmployeeId)
                .Index(t => t.DependentEmployee_EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BiWeeklyWage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DependentEmployee_EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Employees", t => t.DependentEmployee_EmployeeId)
                .Index(t => t.DependentEmployee_EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DependentEmployee_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Dependents", "DependentEmployee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.Employees", new[] { "DependentEmployee_EmployeeId" });
            DropIndex("dbo.Dependents", new[] { "DependentEmployee_EmployeeId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Dependents");
        }
    }
}
