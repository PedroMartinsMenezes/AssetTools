namespace AssetTool
{
    public class AssetHeader
    {
        public FPackageFileSummary PackageFileSummary;
        public List<FNameEntrySerialized> NameMap;
        public List<FSoftObjectPath> SoftObjectPathList;
        public List<FGatherableTextData> GatherableTextDataList;
        public List<FObjectImport> ImportMap;
        public List<FObjectExport> ExportMap;
        public DependsMap DependsMap;
        public SearchableNamesMap SearchableNamesMap;
        public ThumbnailTable ObjectNameToFileOffsetMap;
        public FObjectThumbnails Thumbnails;
        public AssetRegistryData AssetRegistryData;
        public PadData Pad;

        #region Offsets
        public long[] SummaryOffsets()
        {
            return [0, PackageFileSummary.NameOffset];
        }
        public long[] NameOffsets()
        {
            if (PackageFileSummary.SoftObjectPathsOffset > 0)
                return [PackageFileSummary.NameOffset, PackageFileSummary.SoftObjectPathsOffset];
            if (PackageFileSummary.GatherableTextDataOffset > 0)
                return [PackageFileSummary.NameOffset, PackageFileSummary.GatherableTextDataOffset];
            return [PackageFileSummary.NameOffset, PackageFileSummary.ImportOffset];
        }
        public long[] SoftObjectPathsOffsets()
        {
            if (PackageFileSummary.GatherableTextDataOffset > 0)
                return [PackageFileSummary.SoftObjectPathsOffset, PackageFileSummary.GatherableTextDataOffset];
            return [PackageFileSummary.SoftObjectPathsOffset, PackageFileSummary.ImportOffset];
        }
        public long[] GatherableOffsets()
        {
            if (PackageFileSummary.GatherableTextDataOffset > 0)
                return [PackageFileSummary.GatherableTextDataOffset, PackageFileSummary.ImportOffset];
            return [0, 0];
        }
        public long[] ImportOffsets()
        {
            return [PackageFileSummary.ImportOffset, PackageFileSummary.ExportOffset];
        }
        public long[] ExportOffsets()
        {
            return [PackageFileSummary.ExportOffset, PackageFileSummary.DependsOffset];
        }
        public long[] DependsOffsets()
        {
            return [PackageFileSummary.DependsOffset, PackageFileSummary.SearchableNamesOffset];
        }
        public long[] SearchableNamesOffsets()
        {
            return [PackageFileSummary.SearchableNamesOffset, PackageFileSummary.SearchableNamesOffset + SearchableNamesMap.SizeOf()];
        }
        public long[] ThumbnailTableOffsets()
        {
            return [PackageFileSummary.ThumbnailTableOffset, PackageFileSummary.ThumbnailTableOffset + ObjectNameToFileOffsetMap.SizeOf()];
        }
        public long[] ThumbnailsOffsets()
        {
            long offset1 = ObjectNameToFileOffsetMap.ThumbnailEntries.FirstOrDefault()?.FileOffset ?? 0;
            return [offset1, PackageFileSummary.ThumbnailTableOffset];
        }
        public long[] AssetRegistryDataOffsets()
        {
            return [PackageFileSummary.AssetRegistryDataOffset, PackageFileSummary.TotalHeaderSize];
        }
        #endregion
    }

    public static class StructHeaderExt
    {
        public static void Write(this BinaryWriter writer, AssetHeader item)
        {
            writer.WriteValue(ref item.PackageFileSummary, item.GetType().GetField("PackageFileSummary"));
            writer.WriteValue(ref item.NameMap, item.GetType().GetField("NameMap"));
            writer.WriteValue(ref item.SoftObjectPathList, item.GetType().GetField("SoftObjectPathList"));
            writer.WriteValue(ref item.GatherableTextDataList, item.GetType().GetField("GatherableTextDataList"));
            writer.WriteValue(ref item.ImportMap, item.GetType().GetField("ImportMap"));
            writer.WriteValue(ref item.ExportMap, item.GetType().GetField("ExportMap"));
            writer.WriteValue(ref item.DependsMap, item.GetType().GetField("DependsMap"));
            writer.WriteValue(ref item.SearchableNamesMap, item.GetType().GetField("SearchableNamesMap"));
            writer.BaseStream.Position = item.PackageFileSummary.ThumbnailTableOffset;
            writer.Write(item.ObjectNameToFileOffsetMap);
            writer.BaseStream.Position = item.PackageFileSummary.AssetRegistryDataOffset;
            writer.WriteValue(item.AssetRegistryData, item.GetType().GetField("AssetRegistryData"));
            writer.Write(item.Pad);
        }

        public static void Read(this BinaryReader reader, AssetHeader item)
        {
            item.PackageFileSummary = reader.ReadValue(item.PackageFileSummary, item.GetType().GetField("PackageFileSummary"));
            GlobalObjects.PackageFileSummary = item.PackageFileSummary;
            item.PackageFileSummary.AutoCheck("PackageFileSummary", reader.BaseStream, item.SummaryOffsets());

            item.NameMap = reader.ReadList<FNameEntrySerialized>(item.PackageFileSummary.NameOffset, item.PackageFileSummary.NameCount);
            GlobalNames.Set(item.NameMap);
            item.NameMap.AutoCheck("NameMap", reader.BaseStream, item.NameOffsets());

            item.SoftObjectPathList = reader.ReadList<FSoftObjectPath>(item.PackageFileSummary.SoftObjectPathsOffset, item.PackageFileSummary.SoftObjectPathsCount);
            GlobalObjects.SoftObjectPathList = item.SoftObjectPathList;
            item.SoftObjectPathList.AutoCheck("SoftObjectPathList", reader.BaseStream, item.SoftObjectPathsOffsets());

            item.GatherableTextDataList = reader.ReadList<FGatherableTextData>(item.PackageFileSummary.GatherableTextDataOffset, item.PackageFileSummary.GatherableTextDataCount);
            item.GatherableTextDataList.AutoCheck("GatherableTextData", reader.BaseStream, item.GatherableOffsets());

            item.ImportMap = reader.ReadList<FObjectImport>(item.PackageFileSummary.ImportOffset, item.PackageFileSummary.ImportCount);
            item.ImportMap.AutoCheck("ImportMap", reader.BaseStream, item.ImportOffsets());

            item.ExportMap = reader.ReadList<FObjectExport>(item.PackageFileSummary.ExportOffset, item.PackageFileSummary.ExportCount);
            GlobalObjects.ExportMap = item.ExportMap;
            item.ExportMap.AutoCheck("ExportMap", reader.BaseStream, item.ExportOffsets());

            item.DependsMap = new() { Map = reader.ReadList<DependsMap.PackageIndexes>(item.PackageFileSummary.DependsOffset, item.PackageFileSummary.ExportCount) };
            item.DependsMap.AutoCheck("Depends", reader.BaseStream, item.DependsOffsets());

            reader.BaseStream.Position = item.PackageFileSummary.SearchableNamesOffset;
            item.SearchableNamesMap = reader.ReadValue(item.SearchableNamesMap, item.GetType().GetField("SearchableNamesMap"));
            item.SearchableNamesMap.AutoCheck("SearchableNames", reader.BaseStream, item.SearchableNamesOffsets());

            reader.BaseStream.Position = item.PackageFileSummary.ThumbnailTableOffset;
            item.ObjectNameToFileOffsetMap = reader.Read(item.ObjectNameToFileOffsetMap);
            item.ObjectNameToFileOffsetMap.AutoCheck("ThumbnailTable", reader.BaseStream, item.ThumbnailTableOffsets());

            reader.BaseStream.Position = item.ThumbnailsOffsets()[0];
            item.Thumbnails = reader.Read(item.Thumbnails, item.ObjectNameToFileOffsetMap.ThumbnailEntries.Count);
            item.Thumbnails.AutoCheck("Thumbnails", reader.BaseStream, item.ThumbnailsOffsets());

            reader.BaseStream.Position = item.PackageFileSummary.AssetRegistryDataOffset;
            item.AssetRegistryData = reader.ReadValue(item.AssetRegistryData, item.GetType().GetField("AssetRegistryData"));
            item.AssetRegistryData.AutoCheck("AssetRegistryData", reader.BaseStream, item.AssetRegistryDataOffsets());

            reader.Read(ref item.Pad, item.PackageFileSummary.TotalHeaderSize - reader.BaseStream.Position);
        }
    }
}
