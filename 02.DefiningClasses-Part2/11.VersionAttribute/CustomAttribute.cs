namespace _11.VersionAttribute
{
    using System;
    using Models;

    [VersionAttributes(1, 0)]
    class CustomAttribute
    {
        static void Main()
        {
            Type type = typeof(CustomAttribute);
            object[] attr = type.GetCustomAttributes(false);
            Console.WriteLine(attr[0]);
        }
    }
}
