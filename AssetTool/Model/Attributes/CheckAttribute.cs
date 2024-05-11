using System.ComponentModel;

namespace AssetTool
{
    public class CheckAttribute : DescriptionAttribute
    {
        public CheckAttribute(string value) : base(value) { }

        public CheckAttribute(bool value) : base(value.ToString()) { }
    }
}
