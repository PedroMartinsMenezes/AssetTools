using System.ComponentModel;
using System.Text.Json.Serialization.Metadata;

namespace AssetTool
{
    public class JsonAssetAttribute : DescriptionAttribute
    {
        public static readonly IEnumerable<JsonDerivedType> Types =
            from a in AppDomain.CurrentDomain.GetAssemblies()
            from t in a.GetTypes()
            where t.IsDefined(typeof(JsonAssetAttribute), false)
            select new JsonDerivedType(t, t.Name);

    }
}
