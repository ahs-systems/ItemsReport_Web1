namespace ItemsReport_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumn_Status_In_NewPrimaryPositions : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewPrimaryPositions", "Status", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewPrimaryPositions", "Status");
        }
    }
}
