using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public enum GuestStatus
    {
        Waiting,Gone
    }

    public enum WashingType
    {
        All, Normal, General, Cleanup, Paint
    }

    public enum WashingStatus
    {
        Late,Finished,Washing,New
    }

    public class SearchCarWashingSchedule : IEntity
    {
        public int Id { get; set; }
        public int WashManId { get; set; }
        public string CarNumber { get; set; }
        public DateTime BookedTime { get; set; }
        public DateTime? WashTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public GuestStatus? GuestStatus { get; set; }
        public WashingType? WashingType { get; set; }
        public WashingStatus WashingStatus { get; set; }
        public virtual WashMan WashMan { get; set; }



        public bool IsDate { get; set; }
        public bool IsMonth { get; set; }
        public bool IsYear { get; set; }

        public int Month { get; set; }
        public int Year { get; set; }


    }


    public class CarWashingSchedule : IEntity
    {
        public int Id { get; set; }
        public int WashManId { get; set; }
        public string CarNumber { get; set; }
        public DateTime BookedTime { get;set;}
        public DateTime? WashTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public GuestStatus? GuestStatus { get; set; }
        public WashingType? WashingType { get; set; }
        public WashingStatus WashingStatus { get; set; }
        public virtual WashMan WashMan { get; set; }


    }
}