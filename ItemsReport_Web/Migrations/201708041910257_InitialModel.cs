namespace ItemsReport_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewPrimaryPositions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ItemsReportLetter = c.String(nullable: false, maxLength: 50),
                        PayPeriod = c.Byte(nullable: false),
                        PayPeriod_Year = c.Short(nullable: false),
                        Site = c.Byte(nullable: false),
                        Emp_Num = c.String(nullable: false, maxLength: 50),
                        Emp_Name = c.String(nullable: false, maxLength: 100),
                        Unit = c.String(nullable: false, maxLength: 100),
                        Occupation = c.String(nullable: false, maxLength: 100),
                        Status = c.String(nullable: false, maxLength: 10),
                        EnteredDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewPrimaryPositions");
        }
    }
}
