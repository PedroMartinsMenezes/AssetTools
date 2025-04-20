using System.ComponentModel;

namespace AssetTool
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Enum)]
    public class LocationAttribute : DescriptionAttribute
    {
        public LocationAttribute(string value) : base(value) { }
    }
}
