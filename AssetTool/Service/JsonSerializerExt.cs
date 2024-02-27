using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public static class JsonSerializerExt
    {
        public static T ReadJson<T>(this string path)
        {
            return JsonSerializer.Deserialize<T>(File.ReadAllText(path), options);
        }

        public static string ToJson(this object self)
        {
            string json = JsonSerializer.Serialize(self, options);
            return json;
        }

        public static void SaveToJson(this object self, string path)
        {
            File.WriteAllText(path, JsonSerializer.Serialize(self, options));
        }

        public static T ToObject<T>(this string json)
        {
            return JsonSerializer.Deserialize<T>(json, options);
        }

        public static T ToObject<T>(this object obj)
        {
            return obj is T ? (T)obj : ((JsonElement)obj).Deserialize<T>(options);
        }

        private static JsonSerializerOptions options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
            WriteIndented = true,
            IncludeFields = true,
            Converters =
            {
                new FNameEntrySerializedJsonConverter(),
                new FCustomVersionJsonConverter(),
                new FGuidJsonConverter(),
                new FStringJsonConverter(),
                new FNameEntryIdJsonConverter(),
                new FNameJsonConverter(),
                new FWeakObjectPtrJsonConverter(),
                new FBoolJsonConverter(),
                new FPackageIndexJsonConverter(),
                new FTextKeyJsonConverter(),
                new DependsMapJsonConverter(),
                new FRotatorJsonConverter(),
                new FVector2DJsonConverter(),
                new FVectorJsonConverter(),
                new FPackageIndexJsonConverter(),
                new FObjectImportJsonConverter(),
                new FObjectExportJsonConverter(),
                new FLinearColorJsonConverter(),

                #region PropertyTag Json
                new FStrPropertyJsonJsonConverter(),
                new FNamePropertyJsonJsonConverter(),

                new FIntPropertyJsonJsonConverter(),
                new FUIntPropertyJsonJsonConverter(),
                new FObjectPropertyBaseJsonJsonConverter(),
                new SoftObjectPropertyJsonJsonConverter(),
                new FFloatPropertyJsonJsonConverter(),
                new FGuidPropertyJsonJsonConverter(),
                #endregion
            }
        };
    }
}
