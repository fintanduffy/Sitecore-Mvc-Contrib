﻿using System;
using System.Linq;
using System.Reflection;

namespace Sitecore.Mvc.Contrib
{
    [Obsolete("Use Sitecore.Mvc.Contrib.Reflection.ReflectionUtil")]
    public static class ReflectionUtil
    {
        public static Assembly GetAssemblyFromName(string assemblyName)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                                          .SingleOrDefault(x => x.GetName().Name == assemblyName);
        }
    }
}