using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
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
        public Int32 SoftObjectPathsCount;
        public Int32 SoftObjectPathsOffset;
        public FString LocalizationId = new();
        public Int32 GatherableTextDataCount;
        public Int32 GatherableTextDataOffset;
        public Int32 ExportCount;
        public Int32 ExportOffset;
        public Int32 ImportCount;
        public Int32 ImportOffset;
        public Int32 DependsOffset;
        public Int32 SoftPackageReferencesCount;
        public Int32 SoftPackageReferencesOffset;
        public Int32 SearchableNamesOffset;
        public Int32 ThumbnailTableOffset;
        public FGuid Guid;
        public FGuid PersistentGuid;
        public List<FGenerationInfo> Generations = new();
        public FEngineVersion SavedByEngineVersion = new();
        public FEngineVersion CompatibleWithEngineVersion = new();
        public UInt32 CompressionFlags;
        [JsonInclude] public UInt32 CompressedChunkSize;
        public UInt32 PackageSource;
        [JsonInclude] public UInt32 AdditionalPackagesToCookSize;
        public Int32 AssetRegistryDataOffset;
        public Int64 BulkDataStartOffset;
        public Int32 WorldTileInfoDataOffset;
        public List<Int32> ChunkIDs = new();
        public Int32 PreloadDependencyCount;
        public Int32 PreloadDependencyOffset;
        public Int32 NamesReferencedFromExportDataCount;
        public Int64 PayloadTocOffset;
        public Int32 DataResourceOffset;
    }

    #region Members
    public class FPackageFileVersion
    {
        public Int32 FileVersionUE4;
        public Int32 FileVersionUE5;
    }

    public class FCustomVersionContainer
    {
        public List<FCustomVersion> Versions = new();
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
