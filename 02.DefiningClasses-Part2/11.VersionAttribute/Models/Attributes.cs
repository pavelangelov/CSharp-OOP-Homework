namespace _11.VersionAttribute.Models
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]

    public class VersionAttributes : Attribute
    {
        public VersionAttributes(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Major { get; private set; }

        public int Minor { get; private set; }

        public override string ToString()
        {
            return $"Version {this.Major}.{this.Minor}";
        }

    }
}
