namespace AssetTool.Model
{
    public class FPackageFileSummary
    {
        public Int32 Tag;
        #region
        public Int32 LegacyFileVersion;
        public Int32 LegacyUE3Version;
        #endregion
        public FPackageFileVersion FileVersionUE = new();
        public Int32 FileVersionLicenseeUE;
        public FCustomVersionContainer CustomVersionContainer = new();
        public UInt32 PackageFlags;
        public Int32 TotalHeaderSize;
        public string PackageName;
        public Int32 NameCount;
        public Int32 NameOffset;
        public Int32 SoftObjectPathsCount;
        public Int32 SoftObjectPathsOffset;
        public string LocalizationId;
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
        public Guid Guid;
        public Guid PersistentGuid;
        //TArray<FGenerationInfo> Generations;
        //FEngineVersion SavedByEngineVersion;
        //FEngineVersion CompatibleWithEngineVersion;
        public UInt32 CompressionFlags;
        public UInt32 PackageSource;
        public bool bUnversioned;
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

    public class FPackageFileVersion
    {
        public Int32 FileVersionUE4;
        public Int32 FileVersionUE5;
    }

    public class FCustomVersionContainer
    {
        public List<FCustomVersion> Versions = new();

        internal void Add(int version, string key)
        {
            Versions.Add(new FCustomVersion { Version = version, Key = new Guid(key) });
        }
    }

    public class FCustomVersion
    {
        public Int32 Version;
        public Guid Key;
    }
}
