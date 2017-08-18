namespace ItemsReport_Web1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedEnteredDate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.NewPrimaryPositions", "EnteredDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NewPrimaryPositions", "EnteredDate", c => c.DateTime(nullable: false));
        }
    }
}
