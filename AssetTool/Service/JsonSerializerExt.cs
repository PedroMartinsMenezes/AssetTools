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

        public static void SerializeStructAsset(StructAsset asset, string path)
        {
            for (int i = 0; i < asset.Objects.Count; i++)
            {
                List<object> tags = asset.Objects[i].Obj.Tags;
                SerializeObjects(tags);
            }
            asset.SaveToJson(path);
        }

        private static void SerializeObjects(List<object> tags)
        {
            for (int i = 0; i < tags.Count; i++)
            {
                var obj = tags[i] as FPropertyTag;
                if (obj?.Type?.Value == FBoolProperty.TYPE_NAME) tags[i] = new FBoolPropertyJson(obj);
                else if (obj?.Type?.Value == FByteProperty.TYPE_NAME && obj.Size == 8) tags[i] = new FByte64PropertyJson(obj);
            }
        }

        public static StructAsset DeserializeStructAsset(string path)
        {
            var asset = path.ReadJson<StructAsset>();
            for (int i = 0; i < asset.Objects.Count; i++)
            {
                List<object> tags = asset.Objects[i].Obj.Tags;
                DeserializeObjects(tags);
            }
            return asset;
        }

        private static void DeserializeObjects(List<object> tags)
        {
            for (int i = 0; i < tags.Count; i++)
            {
                object obj = tags[i];
                if (obj is JsonElement elem && elem.ValueKind == JsonValueKind.Object)
                {
                    object tag = null;

                    string elemType = elem.EnumerateObject().First().Name;

                    if (elemType.StartsWith("bool")) tag = elem.Deserialize<FBoolPropertyJson>().GetNative();
                    if (elemType.StartsWith("byte64")) tag = elem.Deserialize<FByte64PropertyJson>().GetNative();

                    if (tag is { }) tags[i] = tag;
                }
            }
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
                new FEnum32PropertyJsonJsonConverter(),
                new FEnum64PropertyJsonJsonConverter(),
                new FByte32PropertyJsonJsonConverter(),
                new SoftObjectPropertyJsonJsonConverter(),
                new FFloatPropertyJsonJsonConverter(),
                new FGuidPropertyJsonJsonConverter(),
                #endregion
            }
        };
    }
}
