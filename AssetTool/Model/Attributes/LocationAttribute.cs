using System.ComponentModel;

namespace AssetTool
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class LocationAttribute : DescriptionAttribute
    {
        public LocationAttribute(string value) : base(value) { }
    }
}
