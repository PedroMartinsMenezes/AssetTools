namespace AssetTool
{
    [Location("class FPackageReader : public FArchiveUObject")]
    public class AssetHeader
    {
        public FPackageFileSummary PackageFileSummary = new();
        public NameMap NameMap;
        public SoftObjectPathList SoftObjectPathList;
        public GatherableTextDataList GatherableTextDataList;
        public ImportMap ImportMap;
        public ExportMap ExportMap;
        public DependsMap DependsMap;
        public SoftPackageReferences SoftPackageReferences;
        public FLinkerTables SearchableNames;
        public FObjectThumbnails Thumbnails;
        public ThumbnailTable ThumbnailTable;
        public AssetRegistryData AssetRegistryData;
        public PadData Pad;

        #region Offsets
        public long[] SummaryOffsets()
        {
            return [0, PackageFileSummary.NameOffset];
        }
        public long[] NameOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.NameCount == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            else if (PackageFileSummary.SoftObjectPathsOffset > 0)
                return [PackageFileSummary.NameOffset, PackageFileSummary.SoftObjectPathsOffset];
            else if (PackageFileSummary.GatherableTextDataOffset > 0)
                return [PackageFileSummary.NameOffset, PackageFileSummary.GatherableTextDataOffset];
            else
                return [PackageFileSummary.NameOffset, PackageFileSummary.ImportOffset];
        }
        public long[] SoftObjectPathsOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.SoftObjectPathsCount == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            else if (PackageFileSummary.GatherableTextDataOffset > 0)
                return [PackageFileSummary.SoftObjectPathsOffset, PackageFileSummary.GatherableTextDataOffset];
            else
                return [PackageFileSummary.SoftObjectPathsOffset, PackageFileSummary.ImportOffset];
        }
        public long[] GatherableOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.GatherableTextDataCount == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            else if (PackageFileSummary.GatherableTextDataOffset > 0)
                return [PackageFileSummary.GatherableTextDataOffset, PackageFileSummary.ImportOffset];
            else
                return [0, 0];
        }
        public long[] ImportOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.ImportCount == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            else
                return [PackageFileSummary.ImportOffset, PackageFileSummary.ExportOffset];
        }
        public long[] ExportOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.ExportCount == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            else
                return [PackageFileSummary.ExportOffset, PackageFileSummary.DependsOffset];
        }
        public long[] DependsOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.DependsOffset == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            if (PackageFileSummary.SoftPackageReferencesOffset == 0)
                return [PackageFileSummary.DependsOffset, PackageFileSummary.DependsOffset];
            else
                return [PackageFileSummary.DependsOffset, PackageFileSummary.SoftPackageReferencesOffset];
        }
        public long[] SoftPackageReferenceOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.SoftPackageReferencesCount == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            long offset1 = PackageFileSummary.SoftPackageReferencesOffset;
            long offset2 = offset1 + 8 * PackageFileSummary.SoftPackageReferencesCount;
            return [offset1, offset2];
        }
        public long[] SearchableNamesOffsets(BinaryReader reader, FLinkerTables searchableNamesMap)
        {
            if (PackageFileSummary.SearchableNamesOffset == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            else
                return [PackageFileSummary.SearchableNamesOffset, PackageFileSummary.SearchableNamesOffset + searchableNamesMap?.SizeOf() ?? 0];
        }
        public long[] ThumbnailsOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.ThumbnailTableOffset == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            else
                return [reader.BaseStream.Position, PackageFileSummary.ThumbnailTableOffset];
        }
        public long[] ThumbnailTableOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.ThumbnailTableOffset == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            else
                return [PackageFileSummary.ThumbnailTableOffset, PackageFileSummary.AssetRegistryDataOffset];
        }
        public long[] AssetRegistryDataOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.AssetRegistryDataOffset == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            else
                return [PackageFileSummary.AssetRegistryDataOffset, ExportMap.ObjectExports[0].SerialOffset];
        }
        #endregion
    }

    public static class StructHeaderExt
    {
        public static void Read(this BinaryReader reader, AssetHeader item) //@@@ remove
        {
            var transfer = GlobalObjects.Transfer;
            long[] offsets;

            GlobalObjects.PackageFileSummary = item.PackageFileSummary;
            offsets = item.SummaryOffsets();
            item.PackageFileSummary.Move(transfer);
            item.PackageFileSummary.SelfCheck("PackageFileSummary", reader.BaseStream, offsets);
            LogInfo(0, offsets, $"PackageFileSummary. Size({item.PackageFileSummary.TotalHeaderSize})");

            offsets = item.NameOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            LogInfo(1, offsets, "NameMap");
            item.NameMap ??= new NameMap(item.PackageFileSummary);
            item.NameMap.Move(transfer);
            GlobalNames.Set(item.NameMap.NameEntries);
            item.NameMap.SelfCheck("NameMap", reader.BaseStream, offsets);

            offsets = item.SoftObjectPathsOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            LogInfo(2, offsets, "SoftObjectPathList");
            item.SoftObjectPathList ??= new SoftObjectPathList(item.PackageFileSummary);
            item.SoftObjectPathList.Move(transfer);
            GlobalObjects.SoftObjectPathList = item.SoftObjectPathList.SoftObjectPaths;
            item.SoftObjectPathList.SelfCheck("SoftObjectPathList", reader.BaseStream, offsets);

            offsets = item.GatherableOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            LogInfo(3, offsets, "GatherableTextDataList");
            item.GatherableTextDataList ??= new GatherableTextDataList(item.PackageFileSummary);
            item.GatherableTextDataList.Move(transfer);
            item.GatherableTextDataList.SelfCheck("GatherableTextData", reader.BaseStream, offsets);

            offsets = item.ImportOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            LogInfo(4, offsets, "ImportMap");
            item.ImportMap ??= new ImportMap(item.PackageFileSummary);
            item.ImportMap.Move(transfer);
            item.ImportMap.SelfCheck("ImportMap", reader.BaseStream, offsets);

            offsets = item.ExportOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            LogInfo(5, offsets, "ExportMap");
            item.ExportMap ??= new ExportMap(item.PackageFileSummary);
            item.ExportMap.Move(transfer);
            GlobalObjects.ExportMap = item.ExportMap.ObjectExports;
            item.ExportMap.SelfCheck("ExportMap", reader.BaseStream, offsets);

            offsets = item.DependsOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            LogInfo(6, offsets, "DependsMap");
            item.DependsMap ??= new DependsMap(item.PackageFileSummary);
            item.DependsMap.Move(transfer);
            item.DependsMap.SelfCheck("Depends", reader.BaseStream, offsets);

            offsets = item.SoftPackageReferenceOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            LogInfo(7, offsets, "SoftPackageReferenceList");
            item.SoftPackageReferences ??= new SoftPackageReferences(item.PackageFileSummary);
            item.SoftPackageReferences.Move(transfer);
            item.SoftPackageReferences.SelfCheck("SoftPackageReferenceList", reader.BaseStream, offsets);

            offsets = item.SearchableNamesOffsets(reader, null);
            reader.BaseStream.Position = offsets[0];
            item.SearchableNames ??= new FLinkerTables(item.PackageFileSummary);
            item.SearchableNames.Move(transfer);
            offsets = item.SearchableNamesOffsets(reader, item.SearchableNames);
            LogInfo(8, offsets, "SearchableNamesMap");
            item.SearchableNames.SelfCheck("SearchableNames", reader.BaseStream, offsets);

            offsets = item.ThumbnailsOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            LogInfo(9, offsets, "Thumbnails");
            item.Thumbnails ??= new FObjectThumbnails(item.PackageFileSummary);
            item.Thumbnails.Move(transfer);
            item.Thumbnails.SelfCheck("Thumbnails", reader.BaseStream, offsets);

            offsets = item.ThumbnailTableOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            LogInfo(10, offsets, "ThumbnailTable");
            item.ThumbnailTable ??= new ThumbnailTable(item.PackageFileSummary);
            item.ThumbnailTable.Move(transfer);
            item.ThumbnailTable.SelfCheck("ThumbnailTable", reader.BaseStream, offsets);

            offsets = item.AssetRegistryDataOffsets(reader);
            reader.BaseStream.Position = offsets[0];
            LogInfo(11, offsets, "AssetRegistryData");
            item.AssetRegistryData ??= new AssetRegistryData();
            item.AssetRegistryData.Move(transfer);
            item.AssetRegistryData.SelfCheck("AssetRegistryData", reader.BaseStream, offsets);

            reader.Read(ref item.Pad, item.PackageFileSummary.TotalHeaderSize - reader.BaseStream.Position);
        }

        public static void Write(this BinaryWriter writer, AssetHeader item) //@@@ remove
        {
            var transfer = GlobalObjects.Transfer;

            item.PackageFileSummary.Move(transfer);

            item.NameMap.Move(transfer);

            item.SoftObjectPathList.Move(transfer);

            item.GatherableTextDataList.Move(transfer);

            item.ImportMap.Move(transfer);

            item.ExportMap.Move(transfer);

            item.DependsMap.Move(transfer);

            item.SoftPackageReferences.Move(transfer);

            item.SearchableNames.Move(transfer);

            item.Thumbnails.Move(transfer);

            item.ThumbnailTable.Move(transfer);

            item.AssetRegistryData.Move(transfer);

            writer.Write(item.Pad);
        }

        private static void LogInfo(int index, long[] offsets, string msg)
        {
            Log.Info($"[{index}] {offsets[0]} - {offsets[1]} ({offsets[1] - offsets[0],4}): {msg}");
        }
    }
}
