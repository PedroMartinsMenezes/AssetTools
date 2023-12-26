using AssetTool.Model;

namespace AssetTool.Service
{
    public static class PackageFileSummaryExt
    {
        public static void Write(this BinaryWriter writer, FPackageFileSummary item)
        {
            writer.Write(item.Tag);
            writer.Write(item.LegacyFileVersion);
            writer.Write(item.LegacyUE3Version);
            writer.Write(item.FileVersionUE.FileVersionUE4);
            writer.Write(item.FileVersionUE.FileVersionUE5);
            writer.Write(item.FileVersionLicenseeUE);
            writer.Write(item.CustomVersionContainer.VersionCount);
            writer.Write(item.CustomVersionContainer.Versions);
            writer.Write(item.TotalHeaderSize);
            writer.Write(item.PackageName);
            writer.Write(item.PackageFlags);
            writer.Write(item.NameCount);
            writer.Write(item.NameOffset);
            writer.Write(item.SoftObjectPathsCount);
            writer.Write(item.SoftObjectPathsOffset);
            writer.Write(item.LocalizationId);
            writer.Write(item.GatherableTextDataCount);
            writer.Write(item.GatherableTextDataOffset);
            writer.Write(item.ExportCount);
            writer.Write(item.ExportOffset);
            writer.Write(item.ImportCount);
            writer.Write(item.ImportOffset);
            writer.Write(item.DependsOffset);
            writer.Write(item.SoftPackageReferencesCount);
            writer.Write(item.SoftPackageReferencesOffset);
            writer.Write(item.SearchableNamesOffset);
            writer.Write(item.ThumbnailTableOffset);
            writer.Write(item.Guid);
            writer.Write(item.PersistentGuid);
            writer.Write(item.GenerationCount);
            writer.Write(item.Generations);
            writer.Write(item.SavedByEngineVersion);
            writer.Write(item.CompatibleWithEngineVersion);
            writer.Write(item.CompressionFlags);
            writer.Write(item.CompressedChunkSize);
            writer.Write(item.PackageSource);
            writer.Write(item.AdditionalPackagesToCookSize);
            writer.Write(item.AssetRegistryDataOffset);
            writer.Write(item.BulkDataStartOffset);
            writer.Write(item.WorldTileInfoDataOffset);
            writer.Write(item.ChunkIDsSize);
            writer.Write(item.PreloadDependencyCount);
            writer.Write(item.PreloadDependencyOffset);
            writer.Write(item.NamesReferencedFromExportDataCount);
            writer.Write(item.PayloadTocOffset);
            writer.Write(item.DataResourceOffset);
        }

        public static void Write(this BinaryWriter writer, List<FCustomVersion> list)
        {
            list.ForEach(item =>
            {
                writer.Write(item.Key);
                writer.Write(item.Version);
            });
        }

        public static void Write(this BinaryWriter writer, List<FGenerationInfo> list)
        {
            list.ForEach(item =>
            {
                writer.Write(item.ExportCount);
                writer.Write(item.NameCount);
            });
        }

        public static void Write(this BinaryWriter writer, FEngineVersion item)
        {
            writer.Write(item.Major);
            writer.Write(item.Minor);
            writer.Write(item.Patch);
            writer.Write(item.Changelist);
            writer.Write(item.Branch);
        }
    }
}
