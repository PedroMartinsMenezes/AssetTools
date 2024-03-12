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

        [Location("bool FPackageReader::SerializeSoftPackageReferenceList()")]
        public List<FName> SoftPackageReferenceList;

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
            if (PackageFileSummary.NameCount == 0)
                return [0, 0];
            if (PackageFileSummary.SoftObjectPathsOffset > 0)
                return [PackageFileSummary.NameOffset, PackageFileSummary.SoftObjectPathsOffset];
            if (PackageFileSummary.GatherableTextDataOffset > 0)
                return [PackageFileSummary.NameOffset, PackageFileSummary.GatherableTextDataOffset];
            return [PackageFileSummary.NameOffset, PackageFileSummary.ImportOffset];
        }
        public long[] SoftObjectPathsOffsets()
        {
            if (PackageFileSummary.SoftObjectPathsCount == 0)
                return [0, 0];
            if (PackageFileSummary.GatherableTextDataOffset > 0)
                return [PackageFileSummary.SoftObjectPathsOffset, PackageFileSummary.GatherableTextDataOffset];
            return [PackageFileSummary.SoftObjectPathsOffset, PackageFileSummary.ImportOffset];
        }
        public long[] GatherableOffsets()
        {
            if (PackageFileSummary.GatherableTextDataCount == 0)
                return [0, 0];
            if (PackageFileSummary.GatherableTextDataOffset > 0)
                return [PackageFileSummary.GatherableTextDataOffset, PackageFileSummary.ImportOffset];
            return [0, 0];
        }
        public long[] ImportOffsets()
        {
            if (PackageFileSummary.ImportCount == 0)
                return [0, 0];
            return [PackageFileSummary.ImportOffset, PackageFileSummary.ExportOffset];
        }
        public long[] ExportOffsets()
        {
            if (PackageFileSummary.ExportCount == 0)
                return [0, 0];
            return [PackageFileSummary.ExportOffset, PackageFileSummary.DependsOffset];
        }
        public long[] DependsOffsets()
        {
            return [PackageFileSummary.DependsOffset, PackageFileSummary.SoftPackageReferencesOffset];
        }
        public long[] SoftPackageReferenceOffsets()
        {
            if (PackageFileSummary.SoftPackageReferencesCount == 0)
                return [0, 0];
            long offset1 = PackageFileSummary.SoftPackageReferencesOffset;
            long offset2 = offset1 + 8 * PackageFileSummary.SoftPackageReferencesCount;
            return [offset1, offset2];
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
            return [PackageFileSummary.SearchableNamesOffset + SearchableNamesMap.SizeOf(), PackageFileSummary.ThumbnailTableOffset];
        }
        public long[] AssetRegistryDataOffsets()
        {
            return [PackageFileSummary.AssetRegistryDataOffset, PackageFileSummary.AssetRegistryDataOffset + AssetRegistryData.SizeOf()];
        }
        #endregion
    }

    public static class StructHeaderExt
    {
        public static void Write(this BinaryWriter writer, AssetHeader item)
        {
            writer.Write(item.PackageFileSummary);

            writer.Write(item.NameMap);

            writer.WriteValue(ref item.SoftObjectPathList, item.GetType().GetField("SoftObjectPathList"));

            writer.Write(item.GatherableTextDataList);

            writer.WriteValue(ref item.ImportMap, item.GetType().GetField("ImportMap"));

            writer.WriteValue(ref item.ExportMap, item.GetType().GetField("ExportMap"));

            writer.WriteValue(ref item.DependsMap, item.GetType().GetField("DependsMap"));

            writer.WriteList(item.SoftPackageReferenceList);

            writer.WriteValue(ref item.SearchableNamesMap, item.GetType().GetField("SearchableNamesMap"));

            writer.Write(item.Thumbnails);

            writer.Write(item.ObjectNameToFileOffsetMap);

            writer.Write(item.AssetRegistryData);

            writer.Write(item.Pad);
        }

        public static void Read(this BinaryReader reader, AssetHeader item)
        {
            item.PackageFileSummary = reader.Read(item.PackageFileSummary);
            item.PackageFileSummary.AutoCheck("PackageFileSummary", reader.BaseStream, item.SummaryOffsets(), (writer, obj) => writer.Write(obj));

            reader.BaseStream.Position = item.PackageFileSummary.NameOffset;
            item.NameMap = reader.Read(item.NameMap, item.PackageFileSummary.NameCount);
            GlobalNames.Set(item.NameMap);
            item.NameMap.AutoCheck("NameMap", reader.BaseStream, item.NameOffsets(), (writer, obj) => writer.Write(obj));

            item.SoftObjectPathList = reader.ReadList<FSoftObjectPath>(item.PackageFileSummary.SoftObjectPathsOffset, item.PackageFileSummary.SoftObjectPathsCount);
            GlobalObjects.SoftObjectPathList = item.SoftObjectPathList;
            item.SoftObjectPathList.AutoCheck("SoftObjectPathList", reader.BaseStream, item.SoftObjectPathsOffsets());

            reader.BaseStream.Position = item.PackageFileSummary.GatherableTextDataOffset;
            item.GatherableTextDataList = reader.Read(item.GatherableTextDataList, item.PackageFileSummary.GatherableTextDataCount);
            item.GatherableTextDataList.AutoCheck("GatherableTextData", reader.BaseStream, item.GatherableOffsets(), (writer, obj) => writer.Write(obj));

            item.ImportMap = reader.ReadList<FObjectImport>(item.PackageFileSummary.ImportOffset, item.PackageFileSummary.ImportCount);
            item.ImportMap.AutoCheck("ImportMap", reader.BaseStream, item.ImportOffsets());

            item.ExportMap = reader.ReadList<FObjectExport>(item.PackageFileSummary.ExportOffset, item.PackageFileSummary.ExportCount);
            GlobalObjects.ExportMap = item.ExportMap;
            item.ExportMap.AutoCheck("ExportMap", reader.BaseStream, item.ExportOffsets());

            item.DependsMap = new() { Map = reader.ReadList<DependsMap.PackageIndexes>(item.PackageFileSummary.DependsOffset, item.PackageFileSummary.ExportCount) };
            item.DependsMap.AutoCheck("Depends", reader.BaseStream, item.DependsOffsets());

            item.SoftPackageReferenceList = reader.ReadList<FName>(-1, item.PackageFileSummary.SoftPackageReferencesCount);
            item.SoftPackageReferenceList.AutoCheck("SoftPackageReferenceList", reader.BaseStream, item.SoftPackageReferenceOffsets());

            reader.BaseStream.Position = item.PackageFileSummary.SearchableNamesOffset;
            item.SearchableNamesMap = reader.ReadValue(item.SearchableNamesMap, item.GetType().GetField("SearchableNamesMap"));
            item.SearchableNamesMap.AutoCheck("SearchableNames", reader.BaseStream, item.SearchableNamesOffsets());

            item.Thumbnails = reader.Read(item.Thumbnails, item.PackageFileSummary.ThumbnailTableOffset);
            item.Thumbnails.AutoCheck("Thumbnails", reader.BaseStream, item.ThumbnailsOffsets());

            reader.BaseStream.Position = item.PackageFileSummary.ThumbnailTableOffset;
            item.ObjectNameToFileOffsetMap = reader.Read(item.ObjectNameToFileOffsetMap);
            item.ObjectNameToFileOffsetMap.AutoCheck("ThumbnailTable", reader.BaseStream, item.ThumbnailTableOffsets());

            reader.BaseStream.Position = item.PackageFileSummary.AssetRegistryDataOffset;
            item.AssetRegistryData = reader.Read(item.AssetRegistryData);
            item.AssetRegistryData.AutoCheck("AssetRegistryData", reader.BaseStream, item.AssetRegistryDataOffsets(), (writer, obj) => writer.Write(obj));

            reader.Read(ref item.Pad, item.PackageFileSummary.TotalHeaderSize - reader.BaseStream.Position);
        }
    }
}
