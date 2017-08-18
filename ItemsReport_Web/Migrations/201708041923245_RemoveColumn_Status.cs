namespace ItemsReport_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveColumn_Status : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.NewPrimaryPositions", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NewPrimaryPositions", "Status", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
