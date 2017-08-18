namespace ItemsReport_Web1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedTheNppModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ItemsReportLetters", "desc", c => c.String(nullable: false));
            AlterColumn("dbo.PayPeriods", "desc", c => c.String(nullable: false));
            AlterColumn("dbo.Status", "desc", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Status", "desc", c => c.String());
            AlterColumn("dbo.PayPeriods", "desc", c => c.String());
            AlterColumn("dbo.ItemsReportLetters", "desc", c => c.String());
        }
    }
}
