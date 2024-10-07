using System.ComponentModel;

namespace AssetTool
{
    [AttributeUsage(AttributeTargets.Method)]
    public class LocationAttribute : DescriptionAttribute
    {
        public LocationAttribute(string value) : base(value) { }
    }
}
