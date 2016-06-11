namespace DefiningClassesPartTwo.Attribute
{
    using System;

    [Version("1.00")]
    public class AttributeDemo
    {
        public static void Main()
        {
            Type type = typeof(AttributeDemo);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute versionAttribute in allAttributes)
            {
                Console.WriteLine("Version {0}", versionAttribute.Version);
            }
        }
    }
}
