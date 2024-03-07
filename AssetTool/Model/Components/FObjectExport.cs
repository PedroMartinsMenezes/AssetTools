using System.Text.Json;
using System.Text.Json.Serialization;

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
        [Check("CheckDummyPackageGuid")] public FGuid DummyPackageGuid;
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
        public bool CheckDummyPackageGuid() => !Supports.REMOVE_OBJECT_EXPORT_PACKAGE_GUID;
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
                        ClassIndex = string.IsNullOrEmpty(v[0]) ? null : new(v[0]),
                        SuperIndex = string.IsNullOrEmpty(v[1]) ? null : new(v[1]),
                        TemplateIndex = string.IsNullOrEmpty(v[2]) ? null : new(v[2]),
                        OuterIndex = string.IsNullOrEmpty(v[3]) ? null : new(v[3]),
                        ObjectName = string.IsNullOrEmpty(v[4]) ? null : new(v[4]),
                        ObjectFlags = UInt32.TryParse(v[5], out UInt32 v5) ? v5 : 0,
                        SerialSize = Int64.TryParse(v[6], out Int64 v6) ? v6 : 0,
                        SerialOffset = Int64.TryParse(v[7], out Int64 v7) ? v7 : 0,
                        DummyPackageGuid = string.IsNullOrEmpty(v[8]) ? null : new(v[8]),
                        bForcedExport = string.IsNullOrEmpty(v[9]) ? null : new(v[9]),
                        bNotForClient = string.IsNullOrEmpty(v[10]) ? null : new(v[10]),
                        bNotForServer = string.IsNullOrEmpty(v[11]) ? null : new(v[11]),
                        bIsInheritedInstance = string.IsNullOrEmpty(v[12]) ? null : new(v[12]),
                        PackageFlags = UInt32.TryParse(v[13], out UInt32 v13) ? v13 : 0,
                        bNotAlwaysLoadedForEditorGame = string.IsNullOrEmpty(v[14]) ? null : new(v[14]),
                        bIsAsset = string.IsNullOrEmpty(v[15]) ? null : new(v[15]),
                        bGeneratePublicHash = string.IsNullOrEmpty(v[16]) ? null : new(v[16]),
                        FirstExportDependency = Int32.TryParse(v[17], out Int32 v17) ? v17 : 0,
                        SerializationBeforeSerializationDependencies = Int32.TryParse(v[18], out Int32 v18) ? v18 : 0,
                        CreateBeforeSerializationDependencies = Int32.TryParse(v[19], out Int32 v19) ? v19 : 0,
                        SerializationBeforeCreateDependencies = Int32.TryParse(v[20], out Int32 v20) ? v20 : 0,
                        CreateBeforeCreateDependencies = Int32.TryParse(v[21], out Int32 v21) ? v21 : 0,
                    };
                    list.Add(obj);
                }
            }
            return list;
        }
        public override void Write(Utf8JsonWriter writer, List<FObjectExport> value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();

            string v4;

            foreach (var x in value)
            {
                writer.WriteStringValue($"{x.ClassIndex} | {x.SuperIndex} | {x.TemplateIndex} | {x.OuterIndex} | {x.ObjectName} | {x.ObjectFlags} | {x.SerialSize} | {x.SerialOffset} | {x.DummyPackageGuid} | {x.bForcedExport} | {x.bNotForClient} | {x.bNotForServer} | {x.bIsInheritedInstance} | {x.PackageFlags} | {x.bNotAlwaysLoadedForEditorGame} | {x.bIsAsset} | {x.bGeneratePublicHash} | {x.FirstExportDependency} | {x.SerializationBeforeSerializationDependencies} | {x.CreateBeforeSerializationDependencies} | {x.SerializationBeforeCreateDependencies} | {x.CreateBeforeCreateDependencies}");
            }

            writer.WriteEndArray();
        }
    }
}
