using AssetTool.Model.Basic;
using System.ComponentModel;

namespace AssetTool.Model
{
    [Description("Offset: 0. Size: 406")]
    public class FPackageFileSummary
    {
        public Int32 Tag;
        [Description("New")] public Int32 LegacyFileVersion;
        [Description("New")] public Int32 LegacyUE3Version;
        public FPackageFileVersion FileVersionUE = new();
        public Int32 FileVersionLicenseeUE;
        public FCustomVersionContainer CustomVersionContainer = new();
        public UInt32 PackageFlags;
        public Int32 TotalHeaderSize;
        public FString PackageName = string.Empty;
        public Int32 NameCount;
        public Int32 NameOffset;
        public Int32 SoftObjectPathsCount;
        public Int32 SoftObjectPathsOffset;
        public FString LocalizationId = string.Empty;
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
        public int GenerationCount => Generations.Count;
        public List<FGenerationInfo> Generations = new();
        public FEngineVersion SavedByEngineVersion = new();
        public FEngineVersion CompatibleWithEngineVersion = new();
        public UInt32 CompressionFlags;
        [Description("New")] public UInt32 CompressedChunkSize;
        public UInt32 PackageSource;
        [Description("New")] public UInt32 AdditionalPackagesToCookSize;
        public bool bUnversioned;
        public Int32 AssetRegistryDataOffset;
        public Int64 BulkDataStartOffset;
        public Int32 WorldTileInfoDataOffset;
        [Description("New")] public int ChunkIDsSize;
        public List<Int32> ChunkIDs = new();
        public Int32 PreloadDependencyCount;
        public Int32 PreloadDependencyOffset;
        public Int32 NamesReferencedFromExportDataCount;
        public Int64 PayloadTocOffset;
        public Int32 DataResourceOffset;

        public void AddGeneration(int a, int b)
        {
            Generations.Add(new() { ExportCount = a, NameCount = b });
        }
    }

    public class FPackageFileVersion
    {
        public Int32 FileVersionUE4;
        public Int32 FileVersionUE5;
    }

    public class FCustomVersionContainer
    {
        public Int32 VersionCount => Versions.Count;
        public List<FCustomVersion> Versions = new();

        public void Add(int a, string b)
        {
            Versions.Add(new FCustomVersion { Version = a, Key = new Guid(b) });
        }
    }

    public class FCustomVersion
    {
        public Int32 Version;
        public FGuid Key;
    }

    public class FGenerationInfo
    {
        public Int32 NameCount;
        public Int32 ExportCount;
    }

    public class FEngineVersion
    {
        public UInt16 Major;
        public UInt16 Minor;
        public UInt16 Patch;
        public UInt32 Changelist;
        public FString Branch = string.Empty;

        public void Set(UInt16 a, UInt16 b, UInt16 c, UInt32 d, string e)
        {
            Major = a;
            Minor = b;
            Patch = c;
            Changelist = d;
            Branch = e;
        }
    }
}
