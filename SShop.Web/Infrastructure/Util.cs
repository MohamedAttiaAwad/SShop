using System;
using System.ComponentModel.DataAnnotations;

namespace SShop.Web
{
    public static class Util
    {
        public static string GetCurrentUser()
        {
            return ""; 
        }

        public static string GetEnumDisplayName(this Enum value)
        {
            var fi = value.GetType().GetField(value.ToString());

            DisplayAttribute[] attributes = (DisplayAttribute[])fi.GetCustomAttributes(typeof(DisplayAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Name;
            else
                return value.ToString();
        }
    }
}
