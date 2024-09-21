using AssetTool.Service;
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

        public static StructAsset ToJsonThenToObject(this StructAsset self)
        {
            return JsonSerializer.Serialize(self, options).ToObject<StructAsset>();
        }

        public static void SaveToJson(this object self, string path)
        {
            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }
            File.WriteAllText(path, JsonSerializer.Serialize(self, options));
        }

        public static T ToObject<T>(this string json)
        {
            return JsonSerializer.Deserialize<T>(json, options);
        }

        public static T ToObject<T>(this object obj) where T : new()
        {
            if (obj is null)
                return new T();
            return obj is T ? (T)obj : ((JsonElement)obj).Deserialize<T>(options);
        }

        private static JsonSerializerOptions options = new JsonSerializerOptions
        {
            TypeInfoResolver = new PolymorphicTypeResolver(),
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
                new FRotatorfJsonConverter(),
                new FPackageIndexJsonConverter(),
                new FObjectImportJsonConverter(),
                new FObjectExportJsonConverter(),
                new FDateTimeJsonConverter(),
                new NameMapJsonConverter(),
                new SoftObjectPathListJsonConverter(),

                new FVector2fJsonConverter(),
                new FVector2dJsonConverter(),
                new FVector3fJsonConverter(),
                new FVector3dJsonConverter(),
                new FVector4fJsonConverter(),
                new FVector4dJsonConverter(),
                new FQuat4fJsonConverter(),

                new TInt8JsonConverter(),
                new TUInt8JsonConverter(),
                new TInt16JsonConverter(),
                new TUInt16JsonConverter(),
                new TInt32JsonConverter(),
                new TUInt32JsonConverter(),
                new TInt64JsonConverter(),
                new TUInt64JsonConverter()
            }
        };
    }
}
