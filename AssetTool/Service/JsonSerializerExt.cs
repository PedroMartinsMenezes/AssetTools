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

        public static StructAsset Simplify(this StructAsset asset)
        {
            for (int i = 0; i < asset.Objects.Count; i++)
                SimplifyObjects(asset.Objects[i].Obj.Tags);
            return asset;
        }

        public static AssetObject Simplify(this AssetObject obj)
        {
            SimplifyObjects(obj.Obj.Tags);
            return obj;
        }

        private static void SimplifyObjects(List<object> tags)
        {
            for (int i = 0; i < tags.Count; i++)
            {
                var obj = tags[i] as FPropertyTag;
                if (obj?.Type?.Value == FByteProperty.TYPE_NAME && obj.Size == 8) tags[i] = new FByte64PropertyJson(obj);
                else if (obj?.Type?.Value == FEnumProperty.TYPE_NAME && obj.Size == 8) tags[i] = new FEnum64PropertyJson(obj);
            }
        }

        public static StructAsset Restore(this StructAsset asset)
        {
            for (int i = 0; i < asset.Objects.Count; i++)
                RestoreObjects(asset.Objects[i].Obj.Tags);
            return asset;
        }

        public static AssetObject Restore(this AssetObject obj)
        {
            RestoreObjects(obj.Obj.Tags);
            return obj;
        }

        public static void RestoreObjects(List<object> tags)
        {
            for (int i = 0; i < tags.Count; i++)
            {
                //if (tags[i] is JsonElement arrElem && arrElem.ValueKind == JsonValueKind.Object && arrElem.EnumerateObject().Count() > 1)
                //{
                //    string type = arrElem.EnumerateObject().FirstOrDefault(x => x.Name == "Type").Value.ToString();
                //    string innerType = arrElem.EnumerateObject().FirstOrDefault(x => x.Name == "InnerType").Value.ToString();
                //    if (type == Consts.ArrayProperty && innerType == FStructProperty.TYPE_NAME)
                //    {
                //        List<List<object>> innerStructs = arrElem.EnumerateObject().FirstOrDefault(x => x.Name == "Value").Value.Deserialize<List<List<object>>>();
                //        List<object> originalInnerStructs = arrElem.EnumerateObject().FirstOrDefault(x => x.Name == "Value").Value.Deserialize<List<object>>();
                //        for (int j = 0; j < innerStructs.Count; j++)
                //        {
                //            originalInnerStructs[j] = DeserializeObjects(innerStructs[j]);
                //        }
                //        var tag = arrElem.ToObject<FPropertyTag>();
                //        tag.Value = originalInnerStructs;
                //    }
                //    else
                //    {
                //        List<object> originalInnerStructs = arrElem.EnumerateObject().FirstOrDefault(x => x.Name == "Value").Value.Deserialize<List<object>>();
                //        DeserializeObjects(originalInnerStructs);
                //    }
                //}
                //else 
                if (tags[i] is JsonElement objElem && objElem.ValueKind == JsonValueKind.Object && objElem.EnumerateObject().First().Name is string elemType)
                {
                    if (elemType.StartsWith("byte64")) tags[i] = objElem.Deserialize<FByte64PropertyJson>().GetNative();
                    else if (elemType.StartsWith("enum64")) tags[i] = objElem.Deserialize<FEnum64PropertyJson>().GetNative();
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
                new FByte32PropertyJsonJsonConverter(),
                new SoftObjectPropertyJsonJsonConverter(),
                new FFloatPropertyJsonJsonConverter(),
                new FGuidPropertyJsonJsonConverter(),
                #endregion
            }
        };
    }
}
