using System.Text.Json.Serialization;
using System.Text.Json;

namespace AssetTool
{
    [Location("void operator<<(FStructuredArchive::FSlot Slot, FObjectExport& E)")]
    public class FObjectExport
    {
        public FPackageIndex ClassIndex;
        public FPackageIndex SuperIndex;
        [Check("CheckTemplateIndex")] public FPackageIndex TemplateIndex;
        public FPackageIndex OuterIndex;
        public FName ObjectName;
        public UInt32 ObjectFlags;
        [Check("CheckSerial")] public Int64 SerialSize;
        [Check("CheckSerial")] public Int64 SerialOffset;
        public FBool bForcedExport;
        public FBool bNotForClient;
        public FBool bNotForServer;
        [Check("CheckInheritedInstance")] public FBool bIsInheritedInstance;
        public UInt32 PackageFlags;
        [Check("CheckAlwaysLoadedForEditorGame")] public FBool bNotAlwaysLoadedForEditorGame;
        [Check("CheckIsAsset")] public FBool bIsAsset;
        [Check("CheckGeneratePublicHash")] public FBool bGeneratePublicHash;
        [Check("CheckDeps")] public Int32 FirstExportDependency;
        [Check("CheckDeps")] public Int32 SerializationBeforeSerializationDependencies;
        [Check("CheckDeps")] public Int32 CreateBeforeSerializationDependencies;
        [Check("CheckDeps")] public Int32 SerializationBeforeCreateDependencies;
        [Check("CheckDeps")] public Int32 CreateBeforeCreateDependencies;

        public bool CheckTemplateIndex() => Supports.VER_UE4_TemplateIndex_IN_COOKED_EXPORTS;
        public bool CheckSerial() => Supports.VER_UE4_64BIT_EXPORTMAP_SERIALSIZES;
        public bool CheckInheritedInstance() => Supports.TRACK_OBJECT_EXPORT_IS_INHERITED;
        public bool CheckAlwaysLoadedForEditorGame() => Supports.VER_UE4_LOAD_FOR_EDITOR_GAME;
        public bool CheckIsAsset() => Supports.VER_UE4_COOKED_ASSETS_IN_EDITOR_SUPPORT;
        public bool CheckGeneratePublicHash() => Supports.OPTIONAL_RESOURCES;
        public bool CheckDeps() => Supports.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS;
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
                    var obj = new FObjectExport
                    {
                        ClassIndex = new(v[0]),
                        SuperIndex = new(v[1]),
                        TemplateIndex = new(v[2]),
                        OuterIndex = new(v[3]),
                        ObjectName = new(v[4]),
                        ObjectFlags = UInt32.Parse(v[5]),
                        SerialSize = Int64.Parse(v[6]),
                        SerialOffset = Int64.Parse(v[7]),
                        bForcedExport = new(v[8]),
                        bNotForClient = new(v[9]),
                        bNotForServer = new(v[10]),
                        bIsInheritedInstance = new(v[11]),
                        PackageFlags = UInt32.Parse(v[12]),
                        bNotAlwaysLoadedForEditorGame = new(v[13]),
                        bIsAsset = new(v[14]),
                        bGeneratePublicHash = new(v[15]),
                        FirstExportDependency = Int32.Parse(v[16]),
                        SerializationBeforeSerializationDependencies = Int32.Parse(v[17]),
                        CreateBeforeSerializationDependencies = Int32.Parse(v[18]),
                        SerializationBeforeCreateDependencies = Int32.Parse(v[19]),
                        CreateBeforeCreateDependencies = Int32.Parse(v[20]),
                    };
                    list.Add(obj);
                }
            }
            return list;
        }
        public override void Write(Utf8JsonWriter writer, List<FObjectExport> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            value.ForEach(x => writer.WriteStringValue($"{x.ClassIndex} | {x.SuperIndex} | {x.TemplateIndex} | {x.OuterIndex} | {x.ObjectName} | {x.ObjectFlags} | {x.SerialSize} | {x.SerialOffset} | {x.bForcedExport} | {x.bNotForClient} | {x.bNotForServer} | {x.bIsInheritedInstance} | {x.PackageFlags} | {x.bNotAlwaysLoadedForEditorGame} | {x.bIsAsset} | {x.bGeneratePublicHash} | {x.FirstExportDependency} | {x.SerializationBeforeSerializationDependencies} | {x.CreateBeforeSerializationDependencies} | {x.SerializationBeforeCreateDependencies} | {x.CreateBeforeCreateDependencies}"));
            writer.WriteEndArray();
        }
    }
}
