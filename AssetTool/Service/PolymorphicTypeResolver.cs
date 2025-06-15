using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace AssetTool.Service
{
    public class PolymorphicTypeResolver : DefaultJsonTypeInfoResolver
    {
        static List<JsonDerivedType> _derivedTypes = [];

        static PolymorphicTypeResolver()
        {
            JsonAssetAttribute.Types.ToList().ForEach(t => _derivedTypes.Add(new JsonDerivedType(t, t.Name)));
        }

        public override JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options)
        {
            JsonTypeInfo jsonTypeInfo = base.GetTypeInfo(type, options);
            if (jsonTypeInfo.Type == typeof(UObject))
            {
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
