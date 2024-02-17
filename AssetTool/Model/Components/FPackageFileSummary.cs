using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("void operator<<(FStructuredArchive::FSlot Slot, FPackageFileSummary& Sum)")]
    public class FPackageFileSummary
    {
        public UInt32 Tag;
        [JsonInclude] public Int32 LegacyFileVersion;
        [JsonInclude] public Int32 LegacyUE3Version;
        public FPackageFileVersion FileVersionUE = new();
        public Int32 FileVersionLicenseeUE;
        public FCustomVersionContainer CustomVersionContainer = new();
        public Int32 TotalHeaderSize;
        public FString PackageName = new();
        public UInt32 PackageFlags;
        public Int32 NameCount;
        public Int32 NameOffset;
        [Check("CheckSoftObjectPaths")] public Int32 SoftObjectPathsCount;
        [Check("CheckSoftObjectPaths")] public Int32 SoftObjectPathsOffset;
        [Check("CheckLocalizationId")] public FString LocalizationId = new();
        [Check("CheckGatherableTextData")] public Int32 GatherableTextDataCount;
        [Check("CheckGatherableTextData")] public Int32 GatherableTextDataOffset;
        public Int32 ExportCount;
        public Int32 ExportOffset;
        public Int32 ImportCount;
        public Int32 ImportOffset;
        public Int32 DependsOffset;
        [Check("CheckSoftPackageReferences")] public Int32 SoftPackageReferencesCount;
        [Check("CheckSoftPackageReferences")] public Int32 SoftPackageReferencesOffset;
        [Check("CheckSearchableNamesOffset")] public Int32 SearchableNamesOffset;
        public Int32 ThumbnailTableOffset;
        public FGuid Guid;
        [Check("CheckPersistentGuid")] public FGuid PersistentGuid;
        [Check("CheckOwnerPersistentGuid")] public FGuid OwnerPersistentGuid;
        [Sized] public List<FGenerationInfo> Generations = new();
        [Check("CheckSavedByEngineVersion")] public FEngineVersion SavedByEngineVersion = new();
        [Check("CheckCompatibleWithEngineVersion")] public FEngineVersion CompatibleWithEngineVersion = new();
        public UInt32 CompressionFlags;
        [JsonInclude] public UInt32 CompressedChunkSize;
        public UInt32 PackageSource;
        [JsonInclude] public UInt32 AdditionalPackagesToCookSize;
        public Int32 AssetRegistryDataOffset;
        public Int64 BulkDataStartOffset;
        [Check("CheckWorldTileInfoDataOffset")] public Int32 WorldTileInfoDataOffset;
        [Check("CheckChunkIDs")][Sized] public List<Int32> ChunkIDs = new();
        [Check("CheckPreloadDependency")] public Int32 PreloadDependencyCount;
        [Check("CheckPreloadDependency")] public Int32 PreloadDependencyOffset;
        [Check("CheckNamesReferencedFromExportDataCount")] public Int32 NamesReferencedFromExportDataCount;
        [Check("CheckPayloadTocOffset")] public Int64 PayloadTocOffset;
        [Check("CheckDataResourceOffset")] public Int32 DataResourceOffset;

        #region Checks
        public bool CheckSoftObjectPaths()
        {
            return FileVersionUE.FileVersionUE5 >= (int)EUnrealEngineObjectUE5Version.ADD_SOFTOBJECTPATH_LIST;
        }
        public bool CheckLocalizationId()
        {
            return FileVersionUE.FileVersionUE4 >= (int)EUnrealEngineObjectUE4Version.VER_UE4_ADDED_PACKAGE_SUMMARY_LOCALIZATION_ID;
        }
        public bool CheckGatherableTextData()
        {
            return FileVersionUE.FileVersionUE4 >= (int)EUnrealEngineObjectUE4Version.VER_UE4_SERIALIZE_TEXT_IN_PACKAGES;
        }
        public bool CheckSoftPackageReferences()
        {
            return FileVersionUE.FileVersionUE4 >= (int)EUnrealEngineObjectUE4Version.VER_UE4_ADD_STRING_ASSET_REFERENCES_MAP;
        }
        public bool CheckSearchableNamesOffset()
        {
            return FileVersionUE.FileVersionUE4 >= (int)EUnrealEngineObjectUE4Version.VER_UE4_ADDED_SEARCHABLE_NAMES;
        }
        public bool CheckPersistentGuid()
        {
            return FileVersionUE.FileVersionUE4 >= (int)EUnrealEngineObjectUE4Version.VER_UE4_ADDED_PACKAGE_OWNER;
        }
        public bool CheckOwnerPersistentGuid()
        {
            return FileVersionUE.FileVersionUE4 >= (int)EUnrealEngineObjectUE4Version.VER_UE4_ADDED_PACKAGE_OWNER && FileVersionUE.FileVersionUE4 < (int)EUnrealEngineObjectUE4Version.VER_UE4_NON_OUTER_PACKAGE_IMPORT;
        }
        public bool CheckSavedByEngineVersion()
        {
            return FileVersionUE.FileVersionUE4 >= (int)EUnrealEngineObjectUE4Version.VER_UE4_ENGINE_VERSION_OBJECT;
        }
        public bool CheckCompatibleWithEngineVersion()
        {
            return FileVersionUE.FileVersionUE4 >= (int)EUnrealEngineObjectUE4Version.VER_UE4_PACKAGE_SUMMARY_HAS_COMPATIBLE_ENGINE_VERSION;
        }
        public bool CheckWorldTileInfoDataOffset()
        {
            return FileVersionUE.FileVersionUE4 >= (int)EUnrealEngineObjectUE4Version.VER_UE4_WORLD_LEVEL_INFO;
        }
        public bool CheckChunkIDs()
        {
            return FileVersionUE.FileVersionUE4 >= (int)EUnrealEngineObjectUE4Version.VER_UE4_CHANGED_CHUNKID_TO_BE_AN_ARRAY_OF_CHUNKIDS;
        }
        public bool CheckPreloadDependency()
        {
            return FileVersionUE.FileVersionUE4 >= (int)EUnrealEngineObjectUE4Version.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS;
        }
        public bool CheckNamesReferencedFromExportDataCount()
        {
            return FileVersionUE.FileVersionUE5 >= (int)EUnrealEngineObjectUE5Version.NAMES_REFERENCED_FROM_EXPORT_DATA;
        }
        public bool CheckPayloadTocOffset()
        {
            return FileVersionUE.FileVersionUE5 >= (int)EUnrealEngineObjectUE5Version.PAYLOAD_TOC;
        }
        public bool CheckDataResourceOffset()
        {
            return FileVersionUE.FileVersionUE5 >= (int)EUnrealEngineObjectUE5Version.DATA_RESOURCES;
        }
        #endregion
    }

    #region Members
    public class FPackageFileVersion
    {
        public Int32 FileVersionUE4;
        public Int32 FileVersionUE5;
    }

    public class FCustomVersionContainer
    {
        [Sized] public List<FCustomVersion> Versions = new();
    }

    public class FCustomVersion
    {
        public FGuid Key;
        public Int32 Version;
    }

    public class FGenerationInfo
    {
        public Int32 ExportCount;
        public Int32 NameCount;
    }

    public class FEngineVersion
    {
        public UInt16 Major;
        public UInt16 Minor;
        public UInt16 Patch;
        public UInt32 Changelist;
        public FString Branch = new();
    }
    #endregion

    public class FCustomVersionJsonConverter : JsonConverter<FCustomVersion>
    {
        public override FCustomVersion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var x = reader.GetString()!.Split(',');
            return new FCustomVersion { Version = int.Parse(x[0]), Key = new FGuid(x[1]) };
        }

        public override void Write(Utf8JsonWriter writer, FCustomVersion value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.Version}, {value.Key.Value}");
        }
    }
}
