using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FObjectExport
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
        public FBool bForcedExport;
        public FBool bNotForClient;
        public FBool bNotForServer;
        public FBool bIsInheritedInstance;
        public EPackageFlags PackageFlags;
        public FBool bNotAlwaysLoadedForEditorGame;
        public FBool bIsAsset;
        public FBool bGeneratePublicHash;
        public Int32 FirstExportDependency;
        public Int32 SerializationBeforeSerializationDependencies;
        public Int32 CreateBeforeSerializationDependencies;
        public Int32 SerializationBeforeCreateDependencies;
        public Int32 CreateBeforeCreateDependencies;

        [Location("void operator<<(FStructuredArchive::FSlot Slot, FObjectExport& E)")]
        public void Move(Transfer transfer)
        {
            transfer.Move(ref ClassIndex.Index);
            transfer.Move(ref SuperIndex.Index);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_TemplateIndex_IN_COOKED_EXPORTS))
                TemplateIndex.Move(transfer);

            OuterIndex.Move(transfer);
            transfer.Move(ref ObjectName);
            ObjectFlags = (EObjectFlags)transfer.Move((uint)ObjectFlags);

            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_64BIT_EXPORTMAP_SERIALSIZES))
            {
                SerialSize = transfer.Move((Int32)SerialSize);
                SerialOffset = transfer.Move((Int32)SerialOffset);
            }
            else
            {
                transfer.Move(ref SerialSize);
                transfer.Move(ref SerialOffset);
            }

            transfer.Move(ref bForcedExport);
            transfer.Move(ref bNotForClient);
            transfer.Move(ref bNotForServer);

            if (!Supports.UEVer(EUnrealEngineObjectUE5Version.REMOVE_OBJECT_EXPORT_PACKAGE_GUID))
                transfer.Move(ref DummyPackageGuid);

            if (Supports.UEVer(EUnrealEngineObjectUE5Version.TRACK_OBJECT_EXPORT_IS_INHERITED))
                transfer.Move(ref bIsInheritedInstance);

            PackageFlags = (EPackageFlags)transfer.Move((uint)PackageFlags);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_LOAD_FOR_EDITOR_GAME))
                transfer.Move(ref bNotAlwaysLoadedForEditorGame);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_COOKED_ASSETS_IN_EDITOR_SUPPORT))
                transfer.Move(ref bIsAsset);

            if (Supports.UEVer(EUnrealEngineObjectUE5Version.OPTIONAL_RESOURCES))
                transfer.Move(ref bGeneratePublicHash);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS))
            {
                transfer.Move(ref FirstExportDependency);
                transfer.Move(ref SerializationBeforeSerializationDependencies);
                transfer.Move(ref CreateBeforeSerializationDependencies);
                transfer.Move(ref SerializationBeforeCreateDependencies);
                transfer.Move(ref CreateBeforeCreateDependencies);
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
                    var obj = new FObjectExport
                    {
                        ClassIndex = string.IsNullOrEmpty(v[0]) ? null : new(v[0]),
                        SuperIndex = string.IsNullOrEmpty(v[1]) ? null : new(v[1]),
                        TemplateIndex = string.IsNullOrEmpty(v[2]) ? null : new(v[2]),
                        OuterIndex = string.IsNullOrEmpty(v[3]) ? null : new(v[3]),
                        ObjectName = string.IsNullOrEmpty(v[4]) ? null : new(v[4]),
                        ObjectFlags = EObjectFlags.TryParse(v[5], out EObjectFlags v5) ? v5 : 0,
                        SerialSize = Int64.TryParse(v[6], out Int64 v6) ? v6 : 0,
                        SerialOffset = Int64.TryParse(v[7], out Int64 v7) ? v7 : 0,
                        DummyPackageGuid = string.IsNullOrEmpty(v[8]) ? null : new(v[8]),
                        bForcedExport = string.IsNullOrEmpty(v[9]) ? null : new(v[9]),
                        bNotForClient = string.IsNullOrEmpty(v[10]) ? null : new(v[10]),
                        bNotForServer = string.IsNullOrEmpty(v[11]) ? null : new(v[11]),
                        bIsInheritedInstance = string.IsNullOrEmpty(v[12]) ? null : new(v[12]),
                        PackageFlags = EPackageFlags.TryParse(v[13], out EPackageFlags v13) ? v13 : 0,
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

            foreach (var x in value)
            {
                writer.WriteStringValue($"{x.ClassIndex} | {x.SuperIndex} | {x.TemplateIndex} | {x.OuterIndex} | {x.ObjectName} | {x.ObjectFlags} | {x.SerialSize} | {x.SerialOffset} | {x.DummyPackageGuid} | {x.bForcedExport} | {x.bNotForClient} | {x.bNotForServer} | {x.bIsInheritedInstance} | {x.PackageFlags} | {x.bNotAlwaysLoadedForEditorGame} | {x.bIsAsset} | {x.bGeneratePublicHash} | {x.FirstExportDependency} | {x.SerializationBeforeSerializationDependencies} | {x.CreateBeforeSerializationDependencies} | {x.SerializationBeforeCreateDependencies} | {x.CreateBeforeCreateDependencies}");
            }

            writer.WriteEndArray();
        }
    }
}
