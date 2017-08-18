namespace ItemsReport_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_EnteredBy_Column_In_NewPrimaryPositions : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewPrimaryPositions", "EnteredBy", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewPrimaryPositions", "EnteredBy");
        }
    }
}
