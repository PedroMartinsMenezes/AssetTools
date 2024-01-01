namespace AssetTool
{
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
            reader.Read(ref item.Guid);
            reader.Read(ref item.PersistentGuid);
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

        public static void Write(this BinaryWriter writer, FPackageFileSummary item)
        {
            if (item is null) return;
            writer.Write(item.Tag);
            writer.Write(item.LegacyFileVersion);
            writer.Write(item.LegacyUE3Version);
            writer.Write(item.FileVersionUE.FileVersionUE4);
            writer.Write(item.FileVersionUE.FileVersionUE5);
            writer.Write(item.FileVersionLicenseeUE);
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
            writer.Write(item.ChunkIDs);
            writer.Write(item.PreloadDependencyCount);
            writer.Write(item.PreloadDependencyOffset);
            writer.Write(item.NamesReferencedFromExportDataCount);
            writer.Write(item.PayloadTocOffset);
            writer.Write(item.DataResourceOffset);
        }

        public static void Write(this BinaryWriter writer, List<int> list)
        {
            writer.Write(list.Count);
            list.ForEach(writer.Write);
        }

        public static void Write(this BinaryWriter writer, List<FCustomVersion> list)
        {
            writer.Write(list.Count);
            list.ForEach(item =>
            {
                writer.Write(item.Key);
                writer.Write(item.Version);
            });
        }

        public static void Write(this BinaryWriter writer, List<FGenerationInfo> list)
        {
            writer.Write(list.Count);
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
