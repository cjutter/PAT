namespace PAT.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "DependentEmployee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.Employees", new[] { "DependentEmployee_EmployeeId" });
            DropColumn("dbo.Employees", "DependentEmployee_EmployeeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "DependentEmployee_EmployeeId", c => c.Int());
            CreateIndex("dbo.Employees", "DependentEmployee_EmployeeId");
            AddForeignKey("dbo.Employees", "DependentEmployee_EmployeeId", "dbo.Employees", "EmployeeId");
        }
    }
}
