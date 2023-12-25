using AssetTool.Model;

namespace AssetTool.Service
{
    public static class PackageFileSummaryExt
    {
        public static void Write(this BinaryWriter writer, FPackageFileSummary Sum)
        {
            writer.Write(Sum.Tag);
            writer.Write(Sum.LegacyFileVersion);
            writer.Write(Sum.LegacyUE3Version);
            writer.Write(Sum.FileVersionUE.FileVersionUE4);
            writer.Write(Sum.FileVersionUE.FileVersionUE5);
            writer.Write(Sum.FileVersionLicenseeUE);
            writer.Write(Sum.CustomVersionContainer.VersionCount);
            writer.Write(Sum.CustomVersionContainer.Versions);
            writer.Write(Sum.TotalHeaderSize);
            writer.Write(Sum.PackageNameSize);
            writer.WriteString(Sum.PackageName);
            writer.Write(Sum.PackageFlags);
            writer.Write(Sum.NameCount);
            writer.Write(Sum.NameOffset);
            writer.Write(Sum.SoftObjectPathsCount);
            writer.Write(Sum.SoftObjectPathsOffset);
            writer.Write(Sum.LocalizationIdSize);
            writer.WriteString(Sum.LocalizationId);
            writer.Write(Sum.GatherableTextDataCount);
            writer.Write(Sum.GatherableTextDataOffset);
            writer.Write(Sum.ExportCount);
            writer.Write(Sum.ExportOffset);
            writer.Write(Sum.ImportCount);
            writer.Write(Sum.ImportOffset);
            writer.Write(Sum.DependsOffset);
            writer.Write(Sum.SoftPackageReferencesCount);
            writer.Write(Sum.SoftPackageReferencesOffset);
            writer.Write(Sum.SearchableNamesOffset);
            writer.Write(Sum.ThumbnailTableOffset);
            writer.WriteGuid(Sum.Guid);
            writer.WriteGuid(Sum.PersistentGuid);
            writer.Write(Sum.GenerationCount);
            writer.Write(Sum.Generations);
            writer.Write(Sum.SavedByEngineVersion);
            writer.Write(Sum.CompatibleWithEngineVersion);
            writer.Write(Sum.CompressionFlags);
            writer.Write(Sum.CompressedChunkSize);
            writer.Write(Sum.PackageSource);
            writer.Write(Sum.AdditionalPackagesToCookSize);
            writer.Write(Sum.AssetRegistryDataOffset);
            writer.Write(Sum.BulkDataStartOffset);
            writer.Write(Sum.WorldTileInfoDataOffset);
            writer.Write(Sum.ChunkIDsSize);
            writer.Write(Sum.PreloadDependencyCount);
            writer.Write(Sum.PreloadDependencyOffset);
            writer.Write(Sum.NamesReferencedFromExportDataCount);
            writer.Write(Sum.PayloadTocOffset);
            writer.Write(Sum.DataResourceOffset);
        }

        public static void Write(this BinaryWriter writer, List<FCustomVersion> list)
        {
            list.ForEach(item =>
            {
                writer.WriteGuid(item.Key);
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

        public static void Write(this BinaryWriter writer, FEngineVersion obj)
        {
            writer.Write(obj.Major);
            writer.Write(obj.Minor);
            writer.Write(obj.Patch);
            writer.Write(obj.Changelist);
            writer.Write(obj.BranchSize);
            writer.WriteString(obj.Branch);
        }
    }
}
