using CarScheduleCore.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace CarScheduleCore.Ultility
{

    public class EnumDisplayNameAttribute : Attribute
    {
        private string _displayName;
        public string DisplayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        }
    }
    public static class EnumHelper
    {
        public static string DisplayName(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            EnumDisplayNameAttribute attribute = Attribute.GetCustomAttribute(field, typeof(EnumDisplayNameAttribute)) as EnumDisplayNameAttribute;
            return attribute == null ? value.ToString() : attribute.DisplayName;
        }


        public static IList GetDisplayNames(Type type)
        {
            ArrayList list = new ArrayList();
            Array enumValues = Enum.GetValues(type);
            foreach (Enum value in enumValues)
            {
                list.Add(new KeyValuePair<Enum, string>(value, value.DisplayName()));
            }

            return list;
        }


    }


}
