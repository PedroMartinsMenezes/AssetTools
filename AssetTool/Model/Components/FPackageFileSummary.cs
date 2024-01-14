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

    #region FCustomVersion
    public class FCustomVersion
    {
        public FGuid Key;
        public Int32 Version;
    }

    public static class FCustomVersionExt
    {
        public static void Read(this BinaryReader reader, List<FCustomVersion> list)
        {
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                list.Add(new()
                {
                    Key = new FGuid(reader.ReadBytes(16)),
                    Version = reader.ReadInt32()
                });
            }
        }
    }

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
    #endregion

    #region FGenerationInfo
    public class FGenerationInfo
    {
        public Int32 ExportCount;
        public Int32 NameCount;
    }

    public static class FGenerationInfoExt
    {
        public static void Read(this BinaryReader reader, List<FGenerationInfo> list)
        {
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                list.Add(new()
                {
                    ExportCount = reader.ReadInt32(),
                    NameCount = reader.ReadInt32()
                });
            }
        }
    }
    #endregion

    #region FEngineVersion
    public class FEngineVersion
    {
        public UInt16 Major;
        public UInt16 Minor;
        public UInt16 Patch;
        public UInt32 Changelist;
        public FString Branch = new();
    }

    public static class FEngineVersionExt
    {
        public static void Read(this BinaryReader reader, ref FEngineVersion item)
        {
            reader.Read(ref item.Major);
            reader.Read(ref item.Minor);
            reader.Read(ref item.Patch);
            reader.Read(ref item.Changelist);
            reader.Read(item.Branch);
        }
    }
    #endregion
    #endregion

    public static class PackageFileSummaryExt
    {
        public static FPackageFileSummary ReadPackageFileSummary(this BinaryReader reader)
        {
            FPackageFileSummary item = new();
            reader.Read(ref item.Tag);
            reader.Read(ref item.LegacyFileVersion);
            reader.Read(ref item.LegacyUE3Version);
            reader.Read(ref item.FileVersionUE.FileVersionUE4);
            reader.Read(ref item.FileVersionUE.FileVersionUE5);
            reader.Read(ref item.FileVersionLicenseeUE);
            reader.Read(item.CustomVersionContainer.Versions);
            reader.Read(ref item.TotalHeaderSize);
            reader.Read(item.PackageName);
            reader.Read(ref item.PackageFlags);
            reader.Read(ref item.NameCount);
            reader.Read(ref item.NameOffset);
            reader.Read(ref item.SoftObjectPathsCount);
            reader.Read(ref item.SoftObjectPathsOffset);
            reader.Read(item.LocalizationId);
            reader.Read(ref item.GatherableTextDataCount);
            reader.Read(ref item.GatherableTextDataOffset);
            reader.Read(ref item.ExportCount);
            reader.Read(ref item.ExportOffset);
            reader.Read(ref item.ImportCount);
            reader.Read(ref item.ImportOffset);
            reader.Read(ref item.DependsOffset);
            reader.Read(ref item.SoftPackageReferencesCount);
            reader.Read(ref item.SoftPackageReferencesOffset);
            reader.Read(ref item.SearchableNamesOffset);
            reader.Read(ref item.ThumbnailTableOffset);
            item.Guid = reader.Read(item.Guid);
            item.PersistentGuid = reader.Read(item.PersistentGuid);
            reader.Read(item.Generations);
            reader.Read(ref item.SavedByEngineVersion);
            reader.Read(ref item.CompatibleWithEngineVersion);
            reader.Read(ref item.CompressionFlags);
            reader.Read(ref item.CompressedChunkSize);
            reader.Read(ref item.PackageSource);
            reader.Read(ref item.AdditionalPackagesToCookSize);
            reader.Read(ref item.AssetRegistryDataOffset);
            reader.Read(ref item.BulkDataStartOffset);
            reader.Read(ref item.WorldTileInfoDataOffset);
            reader.Read(item.ChunkIDs);
            reader.Read(ref item.PreloadDependencyCount);
            reader.Read(ref item.PreloadDependencyOffset);
            reader.Read(ref item.NamesReferencedFromExportDataCount);
            reader.Read(ref item.PayloadTocOffset);
            reader.Read(ref item.DataResourceOffset);
            return item;
        }
    }
}
