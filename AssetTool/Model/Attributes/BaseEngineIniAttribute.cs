using System.ComponentModel;

namespace AssetTool
{
    [AttributeUsage(AttributeTargets.Class)]
    public class BaseEngineIniAttribute : DescriptionAttribute
    {
        public BaseEngineIniAttribute(string value) : base(value) { }
    }
}
