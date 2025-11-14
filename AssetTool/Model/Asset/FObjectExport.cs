using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FObjectExport : ITransferable
    {
        #region Original Members
        public FPackageIndex ClassIndex = new();
        public FPackageIndex SuperIndex = new();
        public FPackageIndex TemplateIndex = new();
        public FPackageIndex OuterIndex = new();
        public FName ObjectName;
        public EObjectFlags ObjectFlags;
        public Int64 SerialSize;
        public Int64 SerialOffset;
        public FGuid DummyPackageGuid;
        public FBool bForcedExport;
        public FBool bNotForClient;
        public FBool bNotForServer;
        public FBool bIsInheritedInstance;
        public EPackageFlags PackageFlags;
        public FBool bNotAlwaysLoadedForEditorGame;
        public FBool bIsAsset;
        public FBool bGeneratePublicHash;
        public Int32 FirstExportDependency;
        public Int64 ScriptSerializationStartOffset;
        public Int64 ScriptSerializationEndOffset;
        #endregion

        #region UAssetAPI Members
        public int SerializationBeforeSerializationDependenciesSize;
        public int CreateBeforeSerializationDependenciesSize;
        public int SerializationBeforeCreateDependenciesSize;
        public int CreateBeforeCreateDependenciesSize;
        public List<FPackageIndex> SerializationBeforeSerializationDependencies;
        public List<FPackageIndex> CreateBeforeSerializationDependencies;
        public List<FPackageIndex> SerializationBeforeCreateDependencies;
        public List<FPackageIndex> CreateBeforeCreateDependencies;
        #endregion

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FObjectExport& E)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ClassIndex.Index);
            transfer.Move(ref SuperIndex.Index);

            if (transfer.Supports.VER_UE4_TemplateIndex_IN_COOKED_EXPORTS)
                transfer.Move(ref TemplateIndex.Index);

            transfer.Move(ref OuterIndex.Index);
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
                transfer.Move(ref SerializationBeforeSerializationDependenciesSize);
                transfer.Move(ref CreateBeforeSerializationDependenciesSize);
                transfer.Move(ref SerializationBeforeCreateDependenciesSize);
                transfer.Move(ref CreateBeforeCreateDependenciesSize);
            }

            if (!transfer.GlobalObjects.HasUnversionedProperties() && transfer.Supports.SCRIPT_SERIALIZATION_OFFSET)
            {
                transfer.Move(ref ScriptSerializationStartOffset);
                transfer.Move(ref ScriptSerializationEndOffset);
            }
            return this;
        }

        public static void SerializePreloadDependencies(Transfer transfer, List<FObjectExport> ObjectExports)
        {
            foreach (var exportObj in ObjectExports)
            {
                if (exportObj.SerializationBeforeSerializationDependenciesSize > 0)
                    transfer.Move(ref exportObj.SerializationBeforeSerializationDependencies, exportObj.SerializationBeforeSerializationDependenciesSize);

                if (exportObj.CreateBeforeSerializationDependenciesSize > 0)
                    transfer.Move(ref exportObj.CreateBeforeSerializationDependencies, exportObj.CreateBeforeSerializationDependenciesSize);

                if (exportObj.SerializationBeforeCreateDependenciesSize > 0)
                    transfer.Move(ref exportObj.SerializationBeforeCreateDependencies, exportObj.SerializationBeforeCreateDependenciesSize);

                if (exportObj.CreateBeforeCreateDependenciesSize > 0)
                    transfer.Move(ref exportObj.CreateBeforeCreateDependencies, exportObj.CreateBeforeCreateDependenciesSize);
            }
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
                        #region Original Members
                        ClassIndex = new(v[i++]),
                        SuperIndex = new(v[i++]),
                        TemplateIndex = new(v[i++]),
                        OuterIndex = new(v[i++]),
                        ObjectName = new(v[i++].SmartTrim()),
                        SerialSize = Int64.Parse(v[i++]),
                        SerialOffset = Int64.Parse(v[i++]),
                        DummyPackageGuid = new(v[i++]),
                        bForcedExport = new(v[i++]),
                        bNotForClient = new(v[i++]),
                        bNotForServer = new(v[i++]),
                        bIsInheritedInstance = new(v[i++]),
                        PackageFlags = Enum.Parse<EPackageFlags>(v[i++]),
                        bNotAlwaysLoadedForEditorGame = new(v[i++]),
                        bIsAsset = new(v[i++]),
                        bGeneratePublicHash = new(v[i++]),
                        FirstExportDependency = Int32.Parse(v[i++]),
                        ScriptSerializationStartOffset = Int64.Parse(v[i++]),
                        ScriptSerializationEndOffset = Int64.Parse(v[i++]),
                        #endregion

                        #region UAssetAPI Members
                        SerializationBeforeSerializationDependenciesSize = Int32.Parse(v[i++]),
                        SerializationBeforeSerializationDependencies = v[i++].Length > 0 ? v[i - 1].Split(' ').Select(x => new FPackageIndex { Index = int.Parse(x) }).ToList() : default,

                        CreateBeforeSerializationDependenciesSize = Int32.Parse(v[i++]),
                        CreateBeforeSerializationDependencies = v[i++].Length > 0 ? v[i - 1].Split(' ').Select(x => new FPackageIndex { Index = int.Parse(x) }).ToList() : default,

                        SerializationBeforeCreateDependenciesSize = Int32.Parse(v[i++]),
                        SerializationBeforeCreateDependencies = v[i++].Length > 0 ? v[i - 1].Split(' ').Select(x => new FPackageIndex { Index = int.Parse(x) }).ToList() : default,

                        CreateBeforeCreateDependenciesSize = Int32.Parse(v[i++]),
                        CreateBeforeCreateDependencies = v[i++].Length > 0 ? v[i - 1].Split(' ').Select(x => new FPackageIndex { Index = int.Parse(x) }).ToList() : default,
                        #endregion

                        #region Original Members
                        ObjectFlags = Enum.Parse<EObjectFlags>(v[i]),
                        #endregion
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
                s.Append($"ExportIndex[{index}] | {x.ClassIndex,4}").Append(" | ");
                s.Append(x.SuperIndex).Append(" | ");
                s.Append(x.TemplateIndex).Append(" | ");
                s.Append(x.OuterIndex).Append(" | ");
                s.Append($"'{x.ObjectName}'".PadLeft(40)).Append(" | ");
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

                #region UAssetAPI Members
                s.Append(x.SerializationBeforeSerializationDependenciesSize).Append(" | ");
                s.Append(x.SerializationBeforeSerializationDependencies.ToStr()).Append(" | ");

                s.Append(x.CreateBeforeSerializationDependenciesSize).Append(" | ");
                s.Append(x.CreateBeforeSerializationDependencies.ToStr()).Append(" | ");

                s.Append(x.SerializationBeforeCreateDependenciesSize).Append(" | ");
                s.Append(x.SerializationBeforeCreateDependencies.ToStr()).Append(" | ");

                s.Append(x.CreateBeforeCreateDependenciesSize).Append(" | ");
                s.Append(x.CreateBeforeCreateDependencies.ToStr()).Append(" | ");
                #endregion

                #region Original Members
                s.Append(x.ObjectFlags);
                #endregion

                writer.WriteStringValue(s.ToString());
            }

            writer.WriteEndArray();
        }
    }
}
