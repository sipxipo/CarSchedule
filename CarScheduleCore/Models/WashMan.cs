using System.Collections.Generic;

namespace CarScheduleCore.Models
{
    public class WashMan : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CarWashingSchedule> CarWashings { get; set; }
    }
}
