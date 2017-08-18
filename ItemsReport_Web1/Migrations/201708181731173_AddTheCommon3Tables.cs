namespace ItemsReport_Web1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTheCommon3Tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemsReportLetters",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        desc = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PayPeriods",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        desc = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        desc = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Status");
            DropTable("dbo.PayPeriods");
            DropTable("dbo.ItemsReportLetters");
        }
    }
}
