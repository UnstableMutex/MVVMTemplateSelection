using System;
using System.Collections.Generic;
using System.Reflection;

namespace MVVMTemplateSelection
{
    public static class TypeSource
    {
        private static readonly List<Type> l = new List<Type>();

        internal static IEnumerable<Type> Types
        {
            get { return l; }
        }

        public static void AddAssembly(Assembly assembly)
        {
            l.AddRange(assembly.GetTypes());
        }

        public static void AddType(Type type)
        {
            l.Add(type);
        }
    }
}