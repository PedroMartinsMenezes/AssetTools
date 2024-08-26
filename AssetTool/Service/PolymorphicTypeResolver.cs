using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace AssetTool.Service
{
    public class PolymorphicTypeResolver : DefaultJsonTypeInfoResolver
    {
        public override JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options)
        {
            JsonTypeInfo jsonTypeInfo = base.GetTypeInfo(type, options);
            if (jsonTypeInfo.Type == typeof(UObject))
            {
                jsonTypeInfo.PolymorphismOptions = new JsonPolymorphismOptions
                {
                    TypeDiscriminatorPropertyName = "__type"
                };
                JsonAssetAttribute.Types.ToList().ForEach(t => jsonTypeInfo.PolymorphismOptions.DerivedTypes.Add(new JsonDerivedType(t, t.Name)));
            }
            return jsonTypeInfo;
        }
    }
}
