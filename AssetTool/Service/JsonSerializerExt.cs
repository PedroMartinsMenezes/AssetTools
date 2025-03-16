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

        public static AssetPackage ToJsonThenToObject(this AssetPackage self)
        {
#if DEBUG_JSON
            string json = JsonSerializer.Serialize(self, options);
            return json.ToObject<AssetPackage>();
#else
            return JsonSerializer.Serialize(self, options).ToObject<AssetPackage>();
#endif
        }

        public static void SaveToJson(this object self, string path)
        {
            string outputDir = string.IsNullOrEmpty(Path.GetDirectoryName(path)) ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(path);
            Directory.CreateDirectory(outputDir);
            File.WriteAllText(path, JsonSerializer.Serialize(self, options));
        }

        public static T ToObject<T>(this string json)
        {
            return JsonSerializer.Deserialize<T>(json, options);
        }

        public static T ToObject<T>(this object obj) where T : new()
        {
            if (obj is null)
            {
                return new T();
            }
            else if (obj is T t)
            {
                return t;
            }
            else if (obj is string str)
            {
                return str.ToObject<T>();
            }
            else if (obj is JsonElement jstr && jstr.ValueKind == JsonValueKind.String && typeof(T) == typeof(FString))
            {
                return jstr.Deserialize<T>(options);
            }
            else if (obj is JsonElement json && json.ValueKind == JsonValueKind.String)
            {
                return $"\"{obj}\"".ToObject<T>();
            }
            else if (obj is JsonElement jobj)
            {
                return jobj.Deserialize<T>(options);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static T ToObject<T>(this object obj, Type type)
        {
            if (obj is null)
            {
                return Activator.CreateInstance<T>();
            }
            else if (obj is string s)
            {
                return (T)JsonSerializer.Deserialize(s, type, options);
            }
            else if (obj is JsonElement jstr && jstr.ValueKind == JsonValueKind.String)
            {
                return (T)JsonSerializer.Deserialize($"\"{obj}\"", type, options);
            }
            else if (obj is JsonElement jobj && jobj.ValueKind == JsonValueKind.Object)
            {
                return (T)jobj.Deserialize(type, options);
            }
            else
            {
                throw new InvalidOperationException();
            }
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
                new FRotator3fJsonConverter(),
                new FRotator3dJsonConverter(),

                new FPackageIndexJsonConverter(),
                new FObjectImportJsonConverter(),
                new FObjectExportJsonConverter(),
                new FDateTimeJsonConverter(),
                new NameMapJsonConverter(),
                new SoftObjectPathListJsonConverter(),
                new GatherableTextDataListJsonConverter(),
                new ImportMapJsonConverter(),
                new ExportMapJsonConverter(),
                new FColorJsonConverter(),

                new FVector2fArrayJsonConverter(),
                new FVector2JsonConverter(),
                new FVector2fJsonConverter(),
                new FVector2dJsonConverter(),

                new FVector3JsonConverter(),
                new FVector3fJsonConverter(),
                new FVector3dJsonConverter(),

                new FVector4JsonConverter(),
                new FVector4fJsonConverter(),
                new FVector4dJsonConverter(),

                new FQuat4JsonConverter(),
                new FQuat4fJsonConverter(),
                new FQuat4dJsonConverter(),

                new FLinearColorJsonConverter(),
                new FMatrixJsonConverter(),

                new FBox2DJsonConverter(),
                new FBox2dJsonConverter(),
                new FBox2fJsonConverter(),

                new FMatrixJsonConverter(),
                new FMatrix44fJsonConverter(),
                new FMatrix44dJsonConverter(),

                new FRigidBodyIndexPairJsonConverter(),

                new FRigVMGraphFunctionIdentifierJsonConverter(),
                new AttributeStorageFAttributeKeyJsonConverter(),

                new UInt16ArrayJsonConverter(),

                new TInt8JsonConverter(),
                new TInt16JsonConverter(),
                new TInt32JsonConverter(),
                new TInt64JsonConverter(),
                new TUInt8JsonConverter(),
                new TUInt8ArrayJsonConverter(),
                new TUInt16JsonConverter(),
                new TUInt32JsonConverter(),
                new TUInt64JsonConverter(),
                new TFloatJsonConverter(),
                new TDoubleJsonConverter(),

                new PtrJsonConverter(),
            }
        };
    }
}
