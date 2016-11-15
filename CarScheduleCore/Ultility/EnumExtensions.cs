using CarScheduleCore.Model;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace CarScheduleCore.Ultility
{
    public static class EnumExtensions
    {
        public static string DisplayName(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            EnumDisplayNameAttribute attribute = Attribute.GetCustomAttribute(field, typeof(EnumDisplayNameAttribute)) as EnumDisplayNameAttribute;
            return attribute == null ? value.ToString() : attribute.DisplayName;
        }

    }


  
}
