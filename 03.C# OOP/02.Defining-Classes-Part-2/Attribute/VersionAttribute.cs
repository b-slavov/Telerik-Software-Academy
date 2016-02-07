﻿namespace DefiningClassesPartTwo.Attribute
{
    using System;

    [AttributeUsage(AttributeTargets.Struct |
                    AttributeTargets.Class |
                    AttributeTargets.Interface |
                    AttributeTargets.Enum |
                    AttributeTargets.Method,
                    AllowMultiple = false)]

    public class VersionAttribute : System.Attribute
    {
        public VersionAttribute(string version)
        {
            this.Version = version;
        }

        public string Version { get; private set; }
    }
}