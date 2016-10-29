namespace MvcApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addWashingStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarWashingSchedule", "WashingStatus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CarWashingSchedule", "WashingStatus");
        }
    }
}
