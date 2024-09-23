using System.ComponentModel;

namespace AssetTool
{
    [AttributeUsage(AttributeTargets.Field)]
    public class CheckAttribute : DescriptionAttribute
    {
        public CheckAttribute(string value) : base(value) { }

        public CheckAttribute(bool value) : base(value.ToString()) { }
    }
}
