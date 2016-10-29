namespace MvcApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBookingDateNotNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CarWashingSchedule", "BookedTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CarWashingSchedule", "BookedTime", c => c.DateTime());
        }
    }
}
