using System.ComponentModel;

namespace AssetTool
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Constructor)]
    public class LocationAttribute : DescriptionAttribute
    {
        public LocationAttribute(string value) : base(value) { }

        public LocationAttribute(int line, string value) : base(value) { }
    }
}
