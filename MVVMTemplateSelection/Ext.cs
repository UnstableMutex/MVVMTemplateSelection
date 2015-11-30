using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVMTemplateSelection
{
   public static class Ext
    {
        public static T GetCustomAttribute<T>(this Type type) where T : System.Attribute
        {
            var attrs = type.GetCustomAttributes(false).OfType<T>();
            return attrs.Single();
        }
    }
}
