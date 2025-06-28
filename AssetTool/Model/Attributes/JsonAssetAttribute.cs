using System.ComponentModel;
using System.Reflection;

namespace AssetTool
{
    [AttributeUsage(AttributeTargets.Class)]
    public class JsonAssetAttribute : DescriptionAttribute
    {
        public string TypeName;
        public string TypeNameDeprecated;

        public JsonAssetAttribute(string typeName, string typeNameDeprecated = default) : base(typeName)
        {
            TypeName = typeName;
            TypeNameDeprecated = typeNameDeprecated;
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
