using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class WashMan : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<CarWashingSchedule> CarWashings { get; set; }         
    }
}