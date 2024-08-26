using System.ComponentModel;
using System.Reflection;

namespace AssetTool
{
    public class JsonAssetAttribute : DescriptionAttribute
    {
        public string TypeName;

        public JsonAssetAttribute(string value) : base(value)
        {
            TypeName = value;
        }

        public static readonly IEnumerable<Type> Types =
            from a in AppDomain.CurrentDomain.GetAssemblies()
            from t in a.GetTypes()
            where t.IsDefined(typeof(JsonAssetAttribute), false)
            select t;

        public static readonly IEnumerable<(Type, JsonAssetAttribute)> TypesAndAttributes =
            from a in AppDomain.CurrentDomain.GetAssemblies()
            from t in a.GetTypes()
            where t.IsDefined(typeof(JsonAssetAttribute), false)
            select (t, t.GetCustomAttribute<JsonAssetAttribute>());
    }
}
