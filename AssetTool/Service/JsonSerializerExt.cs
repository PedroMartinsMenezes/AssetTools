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

        public static string ToRawJson(this object self)
        {
            var options = new JsonSerializerOptions
            {
                TypeInfoResolver = new PolymorphicTypeResolver(),
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
                WriteIndented = true,
                IncludeFields = true,
                Converters =
                {
                    new FNameJsonConverter(),
                    new FStringJsonConverter(),
                    new JsonStringEnumConverter(),
                    new FTextKeyJsonConverter(),
                    new FStringJsonConverter(),
                    new FNameJsonConverter(),
                    new FBoolJsonConverter(),
                }
            };
            string json = JsonSerializer.Serialize(self, options);
            return json;
        }

        public static async Task<bool> ToJsonThenToObjectThenMoveAsync(this AssetPackage self, TransferWriter transfer, string context)
        {
            try
            {
                AssetPackage asset = await ToStreamThenToObjectAsync(self);
                bool success = await asset.MoveAsync(transfer, context);

                if (AppConfig.DebugSaveJson)
                {
                    lock (_lock)
                    {
                        string json = JsonSerializer.Serialize(self, DefaultOptions);
                        string path = transfer.GlobalObjects.FileName.GetTempJsonPath();
                        if (!Directory.Exists(Path.GetDirectoryName(path))) Directory.CreateDirectory(Path.GetDirectoryName(path));
                        File.WriteAllText(path, json);
                    }
                }

                if (AppConfig.DebugSaveUasset)
                {
                    lock (_lock)
                    {
                        string path = transfer.GlobalObjects.FileName.GetTempAssetPath();
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

        public static void SaveToJson(this object self, string path, Transfer transfer)
        {
            string outputDir = string.IsNullOrEmpty(Path.GetDirectoryName(path)) ? Directory.GetCurrentDirectory() : Path.GetDirectoryName(path);
            Directory.CreateDirectory(outputDir);
            File.WriteAllText(path, JsonSerializer.Serialize(self, DefaultOptions));
        }

        public static T ToObject<T>(this string json, Transfer transfer = null)
        {
            return JsonSerializer.Deserialize<T>(json, DefaultOptions);
        }

        public static T ToObject<T>(this object obj, Transfer transfer = null) where T : new()
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
                return JsonSerializer.Deserialize<T>(obj.ToString(), DefaultOptions);
            }
        }

        public static T ToObject<T>(this object obj, Type type, Transfer transfer = null) where T : new()
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
                return jobj.Deserialize(type, DefaultOptions);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static object ToStringOrObject(this JsonElement elem)
        {
            if (elem.ValueKind == JsonValueKind.String)
            {
                return elem.GetString();
            }
            else
            {
                return elem.Deserialize<Dictionary<string, object>>(DefaultOptions);
            }
        }

        public static int[] GetIndices(string text, params string[] separators)
        {
            (int a, int b) = (0, 0);
            int[] indices = new int[separators.Length];
            for (int i = 0; i < separators.Length; i += 2)
            {
                int left = text.IndexOf(separators[i], b);
                indices[i] = left < 0 ? -1 : left + separators[i].Length;

                int right = left < 0 ? -1 : text.IndexOf(separators[i + 1], left + separators[i].Length);
                indices[i + 1] = right;

                if (right >= 0)
                    b = right;
            }
            return indices;
        }

        public static bool GetField(string text, string separator1, string separator2, out string field)
        {
            int left = text.IndexOf(separator1);
            int index1 = left < 0 ? -1 : left + separator1.Length;

            int right = left < 0 ? -1 : text.IndexOf(separator2, left + separator1.Length);
            int index2 = right;

            if (index1 >= 0 && index2 >= 0)
            {
                field = text[index1..index2];
                return true;
            }
            else
            {
                field = null;
                return false;
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
                new FEdGraphPinTypeJsonConverter(),
                new UEdGraphPinJsonConverter(),

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
