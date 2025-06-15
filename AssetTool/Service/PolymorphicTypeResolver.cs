using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace AssetTool.Service
{
    public class PolymorphicTypeResolver : DefaultJsonTypeInfoResolver
    {
        private readonly static object _lock = new object();
        static List<JsonDerivedType> _derivedTypes = [];

        public override JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options)
        {
            JsonTypeInfo jsonTypeInfo = base.GetTypeInfo(type, options);
            if (jsonTypeInfo.Type == typeof(UObject))
            {
                lock (_lock)
                {
                    if (_derivedTypes.Count == 0)
                    {
                        JsonAssetAttribute.Types.ToList().ForEach(t => _derivedTypes.Add(new JsonDerivedType(t, t.Name)));
                    }
                }
                jsonTypeInfo.PolymorphismOptions = new JsonPolymorphismOptions
                {
                    TypeDiscriminatorPropertyName = "__type"
                };
                _derivedTypes.ForEach(jsonTypeInfo.PolymorphismOptions.DerivedTypes.Add);
            }
            return jsonTypeInfo;
        }
    }
}
