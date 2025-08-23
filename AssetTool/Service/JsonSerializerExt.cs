using AssetTool.Service;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public static class JsonSerializerExt
    {
        static readonly object _lock = new object();

        public static T ReadJson<T>(this string path, Transfer transfer)
        {
            return JsonSerializer.Deserialize<T>(File.ReadAllText(path), DefaultOptions);
        }

        public static string ToJson(this object self)
        {
            string json = JsonSerializer.Serialize(self, DefaultOptions);
            return json;
        }

        public static byte[] ToBytes(this AssetPackage self, Transfer transfer)
        {
            using MemoryStream outputStream = new();
            using BinaryWriter writer = new BinaryWriter(outputStream);
            using TransferWriter transferWriter = new TransferWriter(writer, transfer, true);
            self.Move(transferWriter, "Writing");
            outputStream.Position = 0;
            return outputStream.ToArray();
        }

        public static T ToJsonThenToObjectFast<T>(this T self, Transfer transfer) where T : ITransferible
        {
            return JsonSerializer.SerializeToDocument(self, DefaultOptions).ToObject<T>(transfer);
        }

        public static async Task<bool> ToJsonThenToObjectThenMoveAsync(this AssetPackage self, TransferWriter transfer, string context)
        {
            if (AppConfig.DebugSaveJson)
            {
                string json = JsonSerializer.Serialize(self, DefaultOptions);
                string folder = "";
                folder = GetFolder(json);
                string path = "";
                lock (_lock)
                {
                    path = $"C:\\Temp\\{folder}\\{transfer.GlobalObjects.FileName.NameOnly()}.json";
                    if (File.Exists(path)) path = path.Replace(".json", $".{Guid.NewGuid()}.json");
                    if (!Directory.Exists(Path.GetDirectoryName(path))) Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                await File.WriteAllTextAsync(path, json);
                AssetPackage asset = json.ToObject<AssetPackage>(transfer);
                bool success = await asset.MoveAsync(transfer, context);
                folder = GetFolder(json);
                path = "";
                lock (_lock)
                {
                    string ext = Path.GetExtension(path);
                    path = $"C:\\Temp\\{folder}\\{transfer.GlobalObjects.FileName.NameWithExtension()}";
                    if (File.Exists(path)) path = path.Replace(ext, $".{Guid.NewGuid()}{ext}");
                    if (!Directory.Exists(Path.GetDirectoryName(path))) Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                await File.WriteAllTextAsync(path, json);
                return success;
            }
            else
            {
                AssetPackage asset = JsonSerializer.Deserialize<AssetPackage>(JsonSerializer.SerializeToUtf8Bytes(self, DefaultOptions), DefaultOptions);
                return await asset.MoveAsync(transfer, context);
            }
        }

        public static bool ToJsonThenToObjectThenMove(this AssetPackage self, Transfer transfer, string context)
        {
            string json = JsonSerializer.Serialize(self, DefaultOptions);
            string folder = "";
            if (AppConfig.DebugSaveJson)
            {
                folder = GetFolder(json);
                string path = "";
                lock (_lock)
                {
                    path = $"C:\\Temp\\{folder}\\{transfer.GlobalObjects.FileName.NameOnly()}.json";
                    if (File.Exists(path)) path = path.Replace(".json", $".{Guid.NewGuid()}.json");
                    if (!Directory.Exists(Path.GetDirectoryName(path))) Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                File.WriteAllText(path, json);
            }
            AssetPackage asset = json.ToObject<AssetPackage>(transfer);
            bool success = asset.Move(transfer, context);
            if (AppConfig.DebugSaveUasset)
            {
                folder = GetFolder(json);
                string path = "";
                lock (_lock)
                {
                    path = $"C:\\Temp\\{folder}\\{transfer.GlobalObjects.FileName.NameOnly()}.uasset";
                    if (File.Exists(path)) path = path.Replace(".uasset", $".{Guid.NewGuid()}.uasset");
                    if (!Directory.Exists(Path.GetDirectoryName(path))) Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                File.WriteAllText(path, json);
            }
            return success;
        }

        public static bool ToJsonThenToObjectThenMoveFast(this AssetPackage self, Transfer transfer, string context)
        {
            return JsonSerializer.SerializeToDocument(self, DefaultOptions).ToObject<AssetPackage>(transfer).Move(transfer, context);
        }

        public static async Task<bool> ToJsonThenToObjectThenMoveFastAsync(this AssetPackage self, Transfer transfer, string context)
        {
            return await JsonSerializer.SerializeToDocument(self, DefaultOptions).ToObject<AssetPackage>(transfer).MoveAsync(transfer, context);
        }

        private static string GetFolder(string json)
        {
            int MB = 1014 * 1014;
            return json.Length < MB ? "KB" : $"{json.Length / MB}MB";
        }

        public static void SaveToJson(this object self, string path, Transfer transfer)
        {
            string outputDir = string.IsNullOrEmpty(Path.GetDirectoryName(path)) ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(path);
            Directory.CreateDirectory(outputDir);
            File.WriteAllText(path, JsonSerializer.Serialize(self, DefaultOptions));
        }

        public static T ToObject<T>(this string json, Transfer transfer)
        {
            return JsonSerializer.Deserialize<T>(json, DefaultOptions);
        }

        public static T ToObject<T>(this JsonDocument doc, Transfer transfer)
        {
            return doc.Deserialize<T>(JsonSerializerExt.DefaultOptions);
        }

        public static T ToObject<T>(this object obj, Transfer transfer) where T : new()
        {
            if (obj == default)
            {
                return new T();
            }
            else if (obj is T t)
            {
                return t;
            }
            else if (obj is string str)
            {
                return str.ToObject<T>(transfer);
            }
            else if (obj is JsonElement jstr && jstr.ValueKind == JsonValueKind.String && typeof(T) == typeof(FString))
            {
                return jstr.Deserialize<T>(JsonSerializerExt.DefaultOptions);
            }
            else if (obj is JsonElement json && json.ValueKind == JsonValueKind.String)
            {
                return json.Deserialize<T>(JsonSerializerExt.DefaultOptions);
            }
            else if (obj is JsonElement jobj)
            {
                return jobj.Deserialize<T>(JsonSerializerExt.DefaultOptions);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static T ToObject<T>(this object obj, Type type, Transfer transfer) where T : new()
        {
            if (obj == default)
            {
                return new T();
            }
            else if (obj is T t)
            {
                return t;
            }
            else if (obj is string str)
            {
                return (T)JsonSerializer.Deserialize(str, type, DefaultOptions);
            }
            else if (obj is JsonElement jstr && jstr.ValueKind == JsonValueKind.String && typeof(T) == typeof(FString))
            {
                return jstr.Deserialize<T>(JsonSerializerExt.DefaultOptions);
            }
            else if (obj is JsonElement jobj) //&& jobj.ValueKind == JsonValueKind.Object)
            {
                return (T)jobj.Deserialize(type, DefaultOptions);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static object ToObject(this object obj, Type type, Transfer transfer)
        {
            if (obj is string str)
            {
                return JsonSerializer.Deserialize(str, type, DefaultOptions);
            }
            else if (obj is JsonElement jobj)
            {
                return jobj.Deserialize(type, DefaultOptions);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static ITransferible ToTransferible(this object obj, Type type, Transfer transfer)
        {
            if (obj == default)
            {
                return (ITransferible)Activator.CreateInstance(type);
            }
            else if (obj is string str)
            {
                return (ITransferible)JsonSerializer.Deserialize(str, type, DefaultOptions);
            }
            else if (obj is JsonElement jobj)
            {
                return (ITransferible)jobj.Deserialize(type, DefaultOptions);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static bool WriteIndented { get; set; } = true;

        public static readonly JsonSerializerOptions DefaultOptions = new JsonSerializerOptions
        {
            TypeInfoResolver = new PolymorphicTypeResolver(),
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            WriteIndented = WriteIndented,
            IncludeFields = true,
            Converters =
            {
                new FNameJsonConverter(),//0
                new FObjectImportJsonConverter(),//1                                       
                new NameMapJsonConverter(),//2
                new SoftObjectPathListJsonConverter(),//3
                new GatherableTextDataListJsonConverter(),//4
                new ImportMapJsonConverter(),//5
                new ExportMapJsonConverter(),//6
                new FVector3JsonConverter(),//7
                new FRigElementKeyJsonConverter(),//8
                new TTupleFNameFNameJsonConverter(),//9
                new FVector4JsonConverter(),//10
                new FVector2JsonConverter(),//11
                new FMeshBoneInfoListJsonConverter(),//12
                new FSoftSkinVertexListJsonConverter(),//13
                new FSimpleMemberReferenceJsonConverter(),//14
                new FObjectExportJsonConverter(),//15

                new FTextJsonConverter(),
                new ParentPinWrapperJsonConverter(),
                new LinkedToWrapperJsonConverter(),
                new TRefJsonConverter(),
                new FTransformListJsonConverter(),
                new FNameEntrySerializedJsonConverter(),
                new FCustomVersionJsonConverter(),
                new FGuidJsonConverter(),
                new FStringJsonConverter(),
                new FNameEntryIdJsonConverter(),
                new FWeakObjectPtrJsonConverter(),
                new FLazyObjectPtrJsonConverter(),
                new FBoolJsonConverter(),
                new FPackageIndexJsonConverter(),
                new FObjectPtrJsonConverter(),
                new FTextKeyJsonConverter(),
                new DependsMapJsonConverter(),
                new FRotatorJsonConverter(),
                new FRotator3fJsonConverter(),
                new FRotator3dJsonConverter(),
                new FDateTimeJsonConverter(),
                new FColorJsonConverter(),

                new FVector2fJsonConverter(),
                new FVector2dJsonConverter(),
                new FVector3fJsonConverter(),
                new FVector3dJsonConverter(),
                new FVector4fJsonConverter(),
                new FVector4dJsonConverter(),
                new FQuatJsonConverter(),
                new FQuat4fJsonConverter(),
                new FQuat4dJsonConverter(),
                new FPlaneJsonConverter(),
                new FPlane4fJsonConverter(),
                new FPlane4dJsonConverter(),
                new FLinearColorJsonConverter(),
                new FBox2DJsonConverter(),
                new FBox2dJsonConverter(),
                new FBox2fJsonConverter(),
                new FMatrixJsonConverter(),
                new FMatrix44fJsonConverter(),
                new FMatrix44dJsonConverter(),
                new FRigidBodyIndexPairJsonConverter(),
                new FRigVMGraphFunctionIdentifierJsonConverter(),
                new AttributeStorageFAttributeKeyJsonConverter(),
                new TInt8JsonConverter(),
                new TInt16JsonConverter(),
                new TInt32JsonConverter(),
                new TListInt32JsonConverter(),
                new TInt64JsonConverter(),
                new TUInt8JsonConverter(),
                new TUInt16JsonConverter(),
                new TUInt32JsonConverter(),
                new TUInt64JsonConverter(),
                new TFloatJsonConverter(),
                new TDoubleJsonConverter(),
                new PtrJsonConverter(),
                new FRigVMOperandJsonConverter(),
                new FGroupInfoJsonConverter(),
                //Array Vector
                new FVector2fArrayJsonConverter(),
                new FVector2dArrayJsonConverter(),
                new FVector3fArrayJsonConverter(),
                new FVector3dArrayJsonConverter(),
                new FVector4fArrayJsonConverter(),
                new FVector4dArrayJsonConverter(),
                //List Vector
                new FVector2fListJsonConverter(),
                new FVector2dListJsonConverter(),
                new FVector3fListJsonConverter(),
                new FVector3dListJsonConverter(),
                new FVector4fListJsonConverter(),
                new FVector4dListJsonConverter(),
                //Array Quat
                new FQuat4fArrayJsonConverter(),
                new FQuat4dArrayJsonConverter(),
                //List Quat
                new FQuat4fListJsonConverter(),
                new FQuat4dListJsonConverter(),
                //Array Scalar
                new Int16ArrayJsonConverter(),
                new UInt16ArrayJsonConverter(),
                new Int32ArrayJsonConverter(),
                new UInt32ArrayJsonConverter(),
                new Int64ArrayJsonConverter(),
                new UInt64ArrayJsonConverter(),
                new FloatArrayJsonConverter(),
                new DoubleArrayJsonConverter(),
                //Array Wrapper
                new TUInt8ArrayJsonConverter(),
                //Enum
                new JsonStringEnumConverter(),
            }
        };
    }
}
