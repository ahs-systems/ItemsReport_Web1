namespace ItemsReport_Web1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBackEnteredDateColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewPrimaryPositions", "EnteredDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewPrimaryPositions", "EnteredDate");
        }
    }
}
