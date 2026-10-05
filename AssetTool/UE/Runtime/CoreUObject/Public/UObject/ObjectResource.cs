using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    #region FPackageIndex
    [DebuggerDisplay("[{Index}] ImportIndex[{ImportIndex}] {TypeName}")]
    public class FPackageIndex : ITransferable
    {
        public const int SIZE = 4;

        public Int32 Index;

        [JsonIgnore] public int ExportIndex;
        [JsonIgnore] public int ImportIndex;
        [JsonIgnore] public string TypeName;

        public FPackageIndex() { }

        public FPackageIndex(int index)
        {
            Index = index;
            if (Index < 0)
                ImportIndex = Index;
            else if (Index > 0)
                ExportIndex = Index;
        }

        public FPackageIndex(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (value.Contains(':'))
                {
                    string token = "ExportIndex[";
                    if (value.Contains(token))
                    {
                        int a = value.IndexOf(token) + token.Length;
                        int b = value.IndexOf(']', a);
                        ExportIndex = int.Parse(value[a..b]);
                    }
                    token = "ImportIndex[";
                    if (value.Contains(token))
                    {
                        int a = value.IndexOf(token) + token.Length;
                        int b = value.IndexOf(']', a);
                        ImportIndex = int.Parse(value[a..b]);
                    }
                    Index = ExportIndex != 0 ? ExportIndex : ImportIndex;
                }
                else
                {
                    Index = int.Parse(value);
                    if (Index < 0)
                        ImportIndex = Index;
                    else if (Index > 0)
                        ExportIndex = Index;
                }
            }
        }

        public ITransferable Move(Transfer transfer)
        {
            return Move(transfer, false);
        }

        public ITransferable Move(Transfer transfer, bool ignore)
        {
            transfer.Move(ref Index);
            if (!ignore && transfer.IsReading)
            {
                UpdateIndexes(transfer);
            }
            return this;
        }

        public void UpdateIndexes(Transfer transfer)
        {
            (ExportIndex, ImportIndex, TypeName) = transfer.GlobalObjects.GetTypeNameFromPackageIndex(Index);
        }

        public override string ToString() => Index.ToString();
        public bool IsImport() => Index < 0;
        public bool IsExport() => Index > 0;
    }

    public class FPackageIndexJsonConverter : JsonConverter<FPackageIndex>
    {
        public override FPackageIndex Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (string.IsNullOrEmpty(value))
            {
                return new FPackageIndex();
            }
            else if (value.Contains(':'))
            {
                int ExportIndex = 0;
                int ImportIndex = 0;
                string token = "ExportIndex[";
                if (value.Contains(token))
                {
                    int a = value.IndexOf(token) + token.Length;
                    int b = value.IndexOf(']', a);
                    ExportIndex = int.Parse(value[a..b]);
                }
                token = "ImportIndex[";
                if (value.Contains(token))
                {
                    int a = value.IndexOf(token) + token.Length;
                    int b = value.IndexOf(']', a);
                    ImportIndex = int.Parse(value[a..b]);
                }
                int Index = ExportIndex != 0 ? ExportIndex : ImportIndex;
                return new FPackageIndex { Index = Index };
            }
            else
            {
                return new FPackageIndex { Index = int.Parse(value) };
            }
        }
        public override FPackageIndex ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }
        public override void Write(Utf8JsonWriter writer, FPackageIndex value, JsonSerializerOptions options)
        {
            if (value.Index == 0)
                writer.WriteStringValue("");
            else if (value.ExportIndex != 0)
                writer.WriteStringValue($"ExportIndex[{value.ExportIndex}] ImportIndex[{value.ImportIndex}]: {value.TypeName}");
            else
                writer.WriteStringValue($"ImportIndex[{value.ImportIndex}]: {value.TypeName}");

        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FPackageIndex value, JsonSerializerOptions options)
        {
            if (value.Index == 0)
                writer.WritePropertyName("");
            else if (value.ExportIndex != 0)
                writer.WritePropertyName($"ExportIndex[{value.ExportIndex}] ImportIndex[{value.ImportIndex}]: {value.TypeName}");
            else
                writer.WritePropertyName($"ImportIndex[{value.ImportIndex}]: {value.TypeName}");
        }
    }

    public static class FPackageIndexExt
    {
        public static string ToStr(this List<FPackageIndex> self)
        {
            return self == default ? string.Empty : string.Join(' ', self.Select(x => x.Index).ToArray());
        }
    }
    #endregion

    public class FObjectDataResource : ITransferable<uint32>
    {
        public EObjectDataResourceFlags Flags = EObjectDataResourceFlags.None;
        public FBulkDataCookedIndex CookedIndex;
        public int64 SerialOffset;
        public int64 DuplicateSerialOffset;
        public int64 SerialSize;
        public int64 RawSize;
        public FPackageIndex OuterIndex;
        public uint32 LegacyBulkDataFlags;

        [Location("void FObjectDataResource::Serialize(FStructuredArchive::FSlot Slot, TArray<FObjectDataResource>& DataResources)")]
        public ITransferable Move(Transfer transfer, uint32 Version)
        {
            transfer.MoveEnum(ref Flags);
            if (Version >= (uint32)EVersion.AddedCookedIndex)
            {
                transfer.Move(ref CookedIndex);
            }
            transfer.Move(ref SerialOffset);
            transfer.Move(ref DuplicateSerialOffset);
            transfer.Move(ref SerialSize);
            transfer.Move(ref RawSize);
            transfer.Move(ref OuterIndex);
            transfer.Move(ref LegacyBulkDataFlags);
            return this;
        }

        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }

        public enum EVersion : uint32
        {
            Invalid,
            Initial,
            AddedCookedIndex,
            LatestPlusOne,
            Latest = LatestPlusOne - 1
        };
    }

    #region FObjectExport
    public class FObjectExport : ITransferable
    {
        public FPackageIndex ClassIndex = new();
        public FPackageIndex SuperIndex = new();
        public FPackageIndex TemplateIndex = new();
        public FPackageIndex OuterIndex = new();
        public FName ObjectName;
        public EObjectFlags ObjectFlags;
        public Int64 SerialSize;
        public Int64 SerialOffset;
        public FGuid DummyPackageGuid;
        public bool bForcedExport;
        public bool bNotForClient;
        public bool bNotForServer;
        public bool bIsInheritedInstance;
        public EPackageFlags PackageFlags;
        public bool bNotAlwaysLoadedForEditorGame;
        public bool bIsAsset;
        public bool bGeneratePublicHash;
        public Int32 FirstExportDependency;
        public Int64 ScriptSerializationStartOffset;
        public Int64 ScriptSerializationEndOffset;
        public PreloadDependencies PreloadDependencies = new();

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FObjectExport& E)")]
        public ITransferable Move(Transfer transfer)
        {
            ClassIndex.Move(transfer, true);
            SuperIndex.Move(transfer, true);

            if (transfer.Supports.VER_UE4_TemplateIndex_IN_COOKED_EXPORTS)
                TemplateIndex.Move(transfer, true);

            OuterIndex.Move(transfer, true);
            transfer.Move(ref ObjectName);
            transfer.MoveEnum(ref ObjectFlags);

            if (!transfer.Supports.VER_UE4_64BIT_EXPORTMAP_SERIALSIZES)
            {
                transfer.MoveAsInt(ref SerialSize);
                transfer.MoveAsInt(ref SerialOffset);
            }
            else
            {
                transfer.Move(ref SerialSize);
                transfer.Move(ref SerialOffset);
            }

            transfer.Move(ref bForcedExport);
            transfer.Move(ref bNotForClient);
            transfer.Move(ref bNotForServer);

            if (!transfer.Supports.REMOVE_OBJECT_EXPORT_PACKAGE_GUID)
                transfer.Move(ref DummyPackageGuid);

            if (transfer.Supports.TRACK_OBJECT_EXPORT_IS_INHERITED)
                transfer.Move(ref bIsInheritedInstance);

            transfer.MoveEnum(ref PackageFlags);

            if (transfer.Supports.VER_UE4_LOAD_FOR_EDITOR_GAME)
                transfer.Move(ref bNotAlwaysLoadedForEditorGame);

            if (transfer.Supports.VER_UE4_COOKED_ASSETS_IN_EDITOR_SUPPORT)
                transfer.Move(ref bIsAsset);

            if (transfer.Supports.OPTIONAL_RESOURCES)
                transfer.Move(ref bGeneratePublicHash);

            if (transfer.Supports.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS)
            {
                transfer.Move(ref FirstExportDependency);
                transfer.Move(ref PreloadDependencies.SerializationBeforeSerializationDependenciesSize);
                transfer.Move(ref PreloadDependencies.CreateBeforeSerializationDependenciesSize);
                transfer.Move(ref PreloadDependencies.SerializationBeforeCreateDependenciesSize);
                transfer.Move(ref PreloadDependencies.CreateBeforeCreateDependenciesSize);
            }

            if (!transfer.GlobalObjects.HasUnversionedProperties() && transfer.Supports.SCRIPT_SERIALIZATION_OFFSET)
            {
                transfer.Move(ref ScriptSerializationStartOffset);
                transfer.Move(ref ScriptSerializationEndOffset);
            }
            return this;
        }

        public void UpdateIndexes(Transfer transfer)
        {
            ClassIndex.UpdateIndexes(transfer);
            SuperIndex.UpdateIndexes(transfer);
            TemplateIndex.UpdateIndexes(transfer);
            OuterIndex.UpdateIndexes(transfer);

            if (transfer.Supports.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS)
            {
                PreloadDependencies.SerializationBeforeSerializationDependencies?.ForEach(x => x.UpdateIndexes(transfer));
                PreloadDependencies.CreateBeforeSerializationDependencies?.ForEach(x => x.UpdateIndexes(transfer));
                PreloadDependencies.SerializationBeforeCreateDependencies?.ForEach(x => x.UpdateIndexes(transfer));
                PreloadDependencies.CreateBeforeCreateDependencies?.ForEach(x => x.UpdateIndexes(transfer));
            }
        }
    }

    public class PreloadDependencies : ITransferable
    {
        public int SerializationBeforeSerializationDependenciesSize;
        public List<FPackageIndex> SerializationBeforeSerializationDependencies;

        public int CreateBeforeSerializationDependenciesSize;
        public List<FPackageIndex> CreateBeforeSerializationDependencies;

        public int SerializationBeforeCreateDependenciesSize;
        public List<FPackageIndex> SerializationBeforeCreateDependencies;

        public int CreateBeforeCreateDependenciesSize;
        public List<FPackageIndex> CreateBeforeCreateDependencies;

        public ITransferable Move(Transfer transfer)
        {
            if (SerializationBeforeSerializationDependenciesSize > 0)
            {
                transfer.Resize(ref SerializationBeforeSerializationDependencies, SerializationBeforeSerializationDependenciesSize);
                SerializationBeforeSerializationDependencies.ForEach(x => x.Move(transfer, true));
            }
            if (CreateBeforeSerializationDependenciesSize > 0)
            {
                transfer.Resize(ref CreateBeforeSerializationDependencies, CreateBeforeSerializationDependenciesSize);
                CreateBeforeSerializationDependencies.ForEach(x => x.Move(transfer, true));
            }
            if (SerializationBeforeCreateDependenciesSize > 0)
            {
                transfer.Resize(ref SerializationBeforeCreateDependencies, SerializationBeforeCreateDependenciesSize);
                SerializationBeforeCreateDependencies.ForEach(x => x.Move(transfer, true));
            }
            if (CreateBeforeCreateDependenciesSize > 0)
            {
                transfer.Resize(ref CreateBeforeCreateDependencies, CreateBeforeCreateDependenciesSize);
                CreateBeforeCreateDependencies.ForEach(x => x.Move(transfer, true));
            }
            return this;
        }
    }

    public class FObjectExportJsonConverter : JsonConverter<List<FObjectExport>>
    {
        public override List<FObjectExport> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            List<FObjectExport> list = [];
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    var v = reader.GetString().Split(" | ");
                    int i = 1;
                    var obj = new FObjectExport
                    {
                        ClassIndex = new(v[i++]),
                        SuperIndex = new(v[i++]),
                        TemplateIndex = new(v[i++]),
                        OuterIndex = new(v[i++]),
                        ObjectName = new(v[i++].SmartTrim()),
                        SerialSize = Int64.Parse(v[i++]),
                        SerialOffset = Int64.Parse(v[i++]),
                        DummyPackageGuid = new(v[i++]),
                        bForcedExport = bool.Parse(v[i++]),
                        bNotForClient = bool.Parse(v[i++]),
                        bNotForServer = bool.Parse(v[i++]),
                        bIsInheritedInstance = bool.Parse(v[i++]),
                        PackageFlags = Enum.Parse<EPackageFlags>(v[i++]),
                        bNotAlwaysLoadedForEditorGame = bool.Parse(v[i++]),
                        bIsAsset = bool.Parse(v[i++]),
                        bGeneratePublicHash = bool.Parse(v[i++]),
                        FirstExportDependency = Int32.Parse(v[i++]),
                        ScriptSerializationStartOffset = Int64.Parse(v[i++]),
                        ScriptSerializationEndOffset = Int64.Parse(v[i++]),
                        PreloadDependencies = new PreloadDependencies()
                        {
                            SerializationBeforeSerializationDependenciesSize = Int32.Parse(v[i++]),
                            SerializationBeforeSerializationDependencies = v[i++].Length > 0 ? v[i - 1].Split(' ').Select(x => new FPackageIndex { Index = int.Parse(x) }).ToList() : default,

                            CreateBeforeSerializationDependenciesSize = Int32.Parse(v[i++]),
                            CreateBeforeSerializationDependencies = v[i++].Length > 0 ? v[i - 1].Split(' ').Select(x => new FPackageIndex { Index = int.Parse(x) }).ToList() : default,

                            SerializationBeforeCreateDependenciesSize = Int32.Parse(v[i++]),
                            SerializationBeforeCreateDependencies = v[i++].Length > 0 ? v[i - 1].Split(' ').Select(x => new FPackageIndex { Index = int.Parse(x) }).ToList() : default,

                            CreateBeforeCreateDependenciesSize = Int32.Parse(v[i++]),
                            CreateBeforeCreateDependencies = v[i++].Length > 0 ? v[i - 1].Split(' ').Select(x => new FPackageIndex { Index = int.Parse(x) }).ToList() : default,
                        },
                        ObjectFlags = Enum.Parse<EObjectFlags>(v[i]),
                    };
                    list.Add(obj);
                }
            }
            return list;
        }
        public override void Write(Utf8JsonWriter writer, List<FObjectExport> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();

            for (int i = 0; i < value.Count; i++)
            {
                var index = i + 1;
                var x = value[i];
                StringBuilder s = new();

                #region Original Members
                s.Append($"ExportIndex[{index,4}] | {x.ClassIndex,4}").Append(" | ");
                s.Append($"{x.SuperIndex,4}").Append(" | ");
                s.Append(x.TemplateIndex).Append(" | ");
                s.Append(x.OuterIndex).Append(" | ");
                s.Append($"'{x.ObjectName}'".PadRight(40)).Append(" | ");
                s.Append(x.SerialSize).Append(" | ");
                s.Append(x.SerialOffset).Append(" | ");
                s.Append(x.DummyPackageGuid).Append(" | ");
                s.Append(x.bForcedExport).Append(" | ");
                s.Append(x.bNotForClient).Append(" | ");
                s.Append(x.bNotForServer).Append(" | ");
                s.Append(x.bIsInheritedInstance).Append(" | ");
                s.Append(x.PackageFlags).Append(" | ");
                s.Append(x.bNotAlwaysLoadedForEditorGame).Append(" | ");
                s.Append(x.bIsAsset).Append(" | ");
                s.Append(x.bGeneratePublicHash).Append(" | ");
                s.Append(x.FirstExportDependency).Append(" | ");
                s.Append(x.ScriptSerializationStartOffset).Append(" | ");
                s.Append(x.ScriptSerializationEndOffset).Append(" | ");
                #endregion

                #region PreloadDependencies Members
                s.Append(x.PreloadDependencies.SerializationBeforeSerializationDependenciesSize).Append(" | ");
                s.Append(x.PreloadDependencies.SerializationBeforeSerializationDependencies.ToStr()).Append(" | ");

                s.Append(x.PreloadDependencies.CreateBeforeSerializationDependenciesSize).Append(" | ");
                s.Append(x.PreloadDependencies.CreateBeforeSerializationDependencies.ToStr()).Append(" | ");

                s.Append(x.PreloadDependencies.SerializationBeforeCreateDependenciesSize).Append(" | ");
                s.Append(x.PreloadDependencies.SerializationBeforeCreateDependencies.ToStr()).Append(" | ");

                s.Append(x.PreloadDependencies.CreateBeforeCreateDependenciesSize).Append(" | ");
                s.Append(x.PreloadDependencies.CreateBeforeCreateDependencies.ToStr()).Append(" | ");
                #endregion

                #region Original Members
                s.Append(x.ObjectFlags);
                #endregion

                writer.WriteStringValue(s.ToString());
            }

            writer.WriteEndArray();
        }
    }
    #endregion

    #region FObjectImport
    public class FObjectImport : ITransferable
    {
        public FName ClassPackage;
        public FName ClassName;
        public FPackageIndex OuterIndex = new();
        public FName ObjectName;
        public FName PackageName;
        public bool bImportOptional;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FObjectImport& I)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ClassPackage);
            transfer.Move(ref ClassName);
            OuterIndex.Move(transfer, true);
            transfer.Move(ref ObjectName);
            if (transfer.Supports.VER_UE4_NON_OUTER_PACKAGE_IMPORT && !transfer.GlobalObjects.IsFilterEditorOnly())
            {
                transfer.Move(ref PackageName);
            }
            if (transfer.Supports.OPTIONAL_RESOURCES)
            {
                transfer.Move(ref bImportOptional);
            }
            return this;
        }

        public void UpdateIndexes(Transfer transfer)
        {
            OuterIndex.UpdateIndexes(transfer);
        }
    }

    public class FObjectImportJsonConverter : JsonConverter<List<FObjectImport>>
    {
        public override List<FObjectImport> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            List<FObjectImport> list = [];
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    var v = reader.GetString().Split(" | ");
                    string classPackage = v[2][1..v[2].IndexOf('\'', 1)];
                    string className = v[3][1..v[3].IndexOf('\'', 1)];
                    string packageName = v[4][1..v[4].IndexOf('\'', 1)];
                    var obj = new FObjectImport
                    {
                        OuterIndex = new FPackageIndex(v[1]),
                        ClassPackage = new FName(classPackage),
                        ClassName = new FName(className),
                        PackageName = new FName(packageName),
                        bImportOptional = bool.Parse(v[5]),
                        ObjectName = new FName(v[6]),
                    };
                    list.Add(obj);
                }
            }
            return list;
        }
        public override void Write(Utf8JsonWriter writer, List<FObjectImport> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            for (int i = 0; i < value.Count; i++)
            {
                var index = -(i + 1);
                var x = value[i];
                string classPackage = $"'{x.ClassPackage}'";
                writer.WriteStringValue($"ImportIndex[{index,4}] | {x.OuterIndex,4} | {classPackage,-30} | '{x.ClassName}' | '{x.PackageName}' | {x.bImportOptional,5} | {x.ObjectName}");
            }
            writer.WriteEndArray();
        }
    }
    #endregion

    public enum EObjectDataResourceFlags : uint32
    {
        None = 0,
        Inline = (1 << 0),
        Streaming = (1 << 1),
        Optional = (1 << 2),
        Duplicate = (1 << 3),
        MemoryMapped = (1 << 4),
        DerivedDataReference = (1 << 5),
    };
}
