namespace MvcApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CarWashingSchedule", "BookedTime", c => c.DateTime());
            AlterColumn("dbo.CarWashingSchedule", "WashTime", c => c.DateTime());
            AlterColumn("dbo.CarWashingSchedule", "FinishTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CarWashingSchedule", "FinishTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CarWashingSchedule", "WashTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CarWashingSchedule", "BookedTime", c => c.DateTime(nullable: false));
        }
    }
}
