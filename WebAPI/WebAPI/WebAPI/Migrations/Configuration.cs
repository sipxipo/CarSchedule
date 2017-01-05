namespace WebAPI.Migrations
{
    using CarScheduleCore.DAL;
    using CarScheduleCore.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarWashContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CarWashContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var washMans = new List<WashMan>
            {
                new WashMan
                {
                    Name = "David"
                },
                new WashMan
                {
                    Name = "Ryan"
                },
                  new WashMan
                {
                    Name = "Peter"
                }
            };
            context.WashMans.AddOrUpdate(p => p.Name, washMans.ToArray());
            context.SaveChanges();

            var carWashingSchedules = new List<CarWashingSchedule>
            {
                  new CarWashingSchedule
                {
                    BookedTime = DateTime.Now.AddDays(1) ,
                    FinishTime = DateTime.Now ,
                    WashTime = DateTime.Now.AddMinutes(10) ,
                    CarNumber = "1234555-SA",
                    WashManId = washMans.Single(s => s.Name == "Peter").Id,
                    WashingType = WashingType.General ,
                    GuestStatus = GuestStatus.Gone,
                    WashingStatus = WashingStatus.New

                },
                new CarWashingSchedule
                {
                    BookedTime = DateTime.Now ,
                    FinishTime = DateTime.Now ,
                    WashTime = DateTime.Now.AddMinutes(10) ,
                    CarNumber = "1234555-SA",
                    WashManId = washMans.Single(s => s.Name == "Ryan").Id,
                    WashingType = WashingType.General ,
                    GuestStatus = GuestStatus.Gone,
                    WashingStatus = WashingStatus.New

                },
                new CarWashingSchedule
                {
                    BookedTime = DateTime.Now.AddHours(1) ,
                    CarNumber = "888888-SA",
                    WashManId = washMans.Single(s => s.Name == "Ryan").Id,
                    WashingType = WashingType.Normal ,
                    GuestStatus = GuestStatus.Waiting,
                    WashingStatus = WashingStatus.New

                },
                 new CarWashingSchedule
                {
                    BookedTime = DateTime.Now ,
                    CarNumber = "444444-SA",
                    WashManId = washMans.Single(s => s.Name == "Ryan").Id,
                    WashingType = WashingType.Normal ,
                    WashingStatus = WashingStatus.Finished
                },
                  new CarWashingSchedule
                {
                    BookedTime = DateTime.Now ,
                    FinishTime = DateTime.Now ,
                    WashTime = DateTime.Now ,
                    CarNumber = "12313-SA",
                    WashManId = washMans.Single(s => s.Name == "Peter").Id,
                    WashingType = WashingType.Normal ,
                    WashingStatus = WashingStatus.Washing
                },
            };
            foreach (CarWashingSchedule e in carWashingSchedules)
            {
                var carWashingsInDataBase = context.CarWashings.Where(
                    s => s.WashMan.Id == e.WashManId).SingleOrDefault();
                if (carWashingsInDataBase == null)
                {
                    context.CarWashings.AddOrUpdate(e);
                }
            }
            context.SaveChanges();

        }
    }
}
