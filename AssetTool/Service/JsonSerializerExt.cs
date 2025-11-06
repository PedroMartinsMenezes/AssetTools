using AssetTool.Service;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public static class JsonSerializerExt
    {
        static readonly object _lock = new object();

        public static T ReadJson<T>(this string path)
        {
            return JsonSerializer.Deserialize<T>(File.ReadAllText(path), DefaultOptions);
        }

        public static string ToJson(this object self)
        {
            string json = JsonSerializer.Serialize(self, DefaultOptions);
            return json;
        }

        public static async Task<bool> ToJsonThenToObjectThenMoveAsync(this AssetPackage self, TransferWriter transfer, string context)
        {
            try
            {
                if (!AppConfig.DebugSaveJson && !AppConfig.DebugSaveUasset)
                {
                    AssetPackage asset = await ToStreamThenToObjectAsync(self);
                    return await asset.MoveAsync(transfer, context);
                }
                else if (!AppConfig.DebugSaveJson && AppConfig.DebugSaveUasset)
                {
                    AssetPackage asset = JsonSerializer.Deserialize<AssetPackage>(JsonSerializer.SerializeToUtf8Bytes(self, DefaultOptions), DefaultOptions);
                    bool success = await asset.MoveAsync(transfer, context);
                    string path = "";
                    lock (_lock)
                    {
                        path = transfer.GlobalObjects.FileName.ReconstructedName();
                        if (!Directory.Exists(Path.GetDirectoryName(path))) Directory.CreateDirectory(Path.GetDirectoryName(path));
                        using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
                        {
                            transfer.Stream.Position = 0;
                            transfer.Stream.CopyTo(fileStream);
                        }
                    }
                    return success;
                }
                else
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
                            File.WriteAllText(path, json);
                        }
                    }
                    AssetPackage asset = json.ToObject<AssetPackage>(transfer);
                    bool success = await asset.MoveAsync(transfer, context);
                    if (AppConfig.DebugSaveUasset)
                    {
                        folder = GetFolder(json);
                        string path = "";
                        lock (_lock)
                        {
                            path = $"C:\\Temp\\{folder}\\{transfer.GlobalObjects.FileName.NameWithExtension()}";
                            string ext = Path.GetExtension(path);
                            if (File.Exists(path)) path = path.Replace(ext, $".{Guid.NewGuid()}{ext}");
                            if (!Directory.Exists(Path.GetDirectoryName(path))) Directory.CreateDirectory(Path.GetDirectoryName(path));
                            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
                            {
                                transfer.Stream.Position = 0;
                                transfer.Stream.CopyTo(fileStream);
                            }
                        }
                    }
                    return success;
                }
            }
            catch
            {
                return false;
            }
        }

        public static async Task<T> ToStreamThenToObjectAsync<T>(T self)
        {
            using var ms = new MemoryStream();
            await JsonSerializer.SerializeAsync(ms, self, DefaultOptions);
            ms.Position = 0;
            T obj = await JsonSerializer.DeserializeAsync<T>(ms, DefaultOptions);
            return obj;
        }

        private static string GetFolder(string json)
        {
            int MB = 1024 * 1024;
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
                return JsonSerializer.Deserialize<T>(obj.ToString(), DefaultOptions);//@@@
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
            else if (obj is JsonElement jobj)
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
                if (typeof(ITransferiblePropertyTag).IsAssignableFrom(type))
                {
                    return jobj.Deserialize(type, DefaultOptions);
                }
                else
                {
                    return jobj.Deserialize(type, DefaultOptions);
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static readonly JsonSerializerOptions DefaultOptions = new JsonSerializerOptions
        {
            TypeInfoResolver = new PolymorphicTypeResolver(),
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            WriteIndented = true,
            IncludeFields = true,
            Converters =
            {
                new FNameJsonConverter(),
                new FObjectImportJsonConverter(),
                new NameMapJsonConverter(),
                new SoftObjectPathListJsonConverter(),
                new GatherableTextDataListJsonConverter(),
                new ImportMapJsonConverter(),
                new ExportMapJsonConverter(),
                new FVector3JsonConverter(),
                new FRigElementKeyJsonConverter(),
                new TTupleFNameFNameJsonConverter(),
                new FVector4JsonConverter(),
                new FVector2JsonConverter(),
                new FMeshBoneInfoListJsonConverter(),
                new FSoftSkinVertexListJsonConverter(),
                new FSimpleMemberReferenceJsonConverter(),
                new FObjectExportJsonConverter(),

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
                new FPackedNormalJsonConverter(),
                new FDeprecatedSerializedPackedNormalJsonConverter(),
                new FFloat16JsonConverter(),
                new FVector2DHalfJsonConverter(),

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
                new TUInt16ArrayJsonConverter(),
                new TBulkListTUInt16JsonConverter(),
                new FVector2DHalfArrayJsonConverter(),
                //Enum
                new JsonStringEnumConverter(),
            }
        };
    }
}
