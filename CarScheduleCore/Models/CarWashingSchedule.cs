﻿using CarScheduleCore.Ultility;
using System;

namespace CarScheduleCore.Models
{
    #region  Enum 
    public enum GuestStatus
    {
        [EnumDisplayName(DisplayName = "Khách đang chờ")]
        Waiting,
        [EnumDisplayName(DisplayName = "Khách về")]
        Gone
    }

    public enum WashingType
    {
        [EnumDisplayName(DisplayName = "Tất cả")]
        All,
        [EnumDisplayName(DisplayName = "Bảo dưỡng")]
        Normal,
        [EnumDisplayName(DisplayName = "Sửa chữa chung")]
        General,
        [EnumDisplayName(DisplayName = "Diệt khuẩn")]
        Cleanup,
        [EnumDisplayName(DisplayName = "Đồng sơn")]
        Paint
    }

    public enum WashingStatus
    {
        Late, Finished, Washing, New
    }
    #endregion

    #region Entity Models
    public class SearchCarWashingSchedule : IEntity
    {
        public int Id { get; set; }
        public int WashManId { get; set; } = -1;
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
        public DateTime BookedTime { get; set; }
        public DateTime? WashTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public GuestStatus? GuestStatus { get; set; }
        public WashingType? WashingType { get; set; }
        public WashingStatus WashingStatus { get; set; }
        public virtual WashMan WashMan { get; set; }
    }
    #endregion
}
