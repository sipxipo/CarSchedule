using MvcApplication1.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MvcApplication1.DAL
{
    public class CarWashContext : DbContext
    {
        public DbSet<WashMan> WashMans { get; set; }
        public DbSet<CarWashingSchedule> CarWashings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}