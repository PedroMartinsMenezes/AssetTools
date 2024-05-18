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
        public long[] SoftObjectPathsOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.SoftObjectPathsCount == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            if (PackageFileSummary.GatherableTextDataOffset > 0)
                return [PackageFileSummary.SoftObjectPathsOffset, PackageFileSummary.GatherableTextDataOffset];
            return [PackageFileSummary.SoftObjectPathsOffset, PackageFileSummary.ImportOffset];
        }
        public long[] GatherableOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.GatherableTextDataCount == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
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
        public long[] SoftPackageReferenceOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.SoftPackageReferencesCount == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            long offset1 = PackageFileSummary.SoftPackageReferencesOffset;
            long offset2 = offset1 + 8 * PackageFileSummary.SoftPackageReferencesCount;
            return [offset1, offset2];
        }
        public long[] SearchableNamesOffsets(BinaryReader reader)
        {
            if (PackageFileSummary.SearchableNamesOffset == 0)
                return [reader.BaseStream.Position, reader.BaseStream.Position];
            else if (SearchableNamesMap is null)
                return [PackageFileSummary.SearchableNamesOffset, PackageFileSummary.SearchableNamesOffset];
            else
                return [PackageFileSummary.SearchableNamesOffset, PackageFileSummary.SearchableNamesOffset + SearchableNamesMap.SizeOf()];
        }
        public long[] ThumbnailsOffsets(BinaryReader reader = null)
        {
            if (reader is { })
                return [reader.BaseStream.Position, PackageFileSummary.ThumbnailTableOffset];
            else
                return [PackageFileSummary.ThumbnailTableOffset - Thumbnails?.SizeOf() ?? 0, PackageFileSummary.ThumbnailTableOffset];
        }
        public long[] ThumbnailTableOffsets()
        {
            return [PackageFileSummary.ThumbnailTableOffset, PackageFileSummary.AssetRegistryDataOffset];
        }
        public long[] AssetRegistryDataOffsets()
        {
            return [PackageFileSummary.AssetRegistryDataOffset, ExportMap[0].SerialOffset];
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

            writer.Write(item.ExportMap);

            writer.WriteValue(ref item.DependsMap, item.GetType().GetField("DependsMap"));

            writer.WriteList(item.SoftPackageReferenceList);

            writer.Write(item.SearchableNamesMap);

            writer.Write(item.Thumbnails);

            writer.Write(item.ObjectNameToFileOffsetMap);

            writer.Write(item.AssetRegistryData);

            writer.Write(item.Pad);
        }

        public static void Read(this BinaryReader reader, AssetHeader item)
        {
            item.PackageFileSummary = reader.Read(item.PackageFileSummary);
            item.PackageFileSummary.AutoCheck("PackageFileSummary", reader.BaseStream, item.SummaryOffsets(), (writer, obj) => writer.Write(obj));
            Log.Info($"[ 0] {item.SummaryOffsets()[0],4} - {item.SummaryOffsets()[1],4} ({item.SummaryOffsets()[1] - item.SummaryOffsets()[0],4}): PackageFileSummary. Size({item.PackageFileSummary.TotalHeaderSize})");

            Log.Info($"[ 1] {item.NameOffsets()[0]} - {item.NameOffsets()[1]} ({item.NameOffsets()[1] - item.NameOffsets()[0]}): NameMap");
            reader.BaseStream.Position = item.PackageFileSummary.NameOffset;
            item.NameMap = reader.Read(item.NameMap, item.PackageFileSummary.NameCount);
            GlobalNames.Set(item.NameMap);
            item.NameMap.AutoCheck("NameMap", reader.BaseStream, item.NameOffsets(), (writer, obj) => writer.Write(obj));

            Log.Info($"[ 2] {item.SoftObjectPathsOffsets(reader)[0]} - {item.SoftObjectPathsOffsets(reader)[1]} ({item.SoftObjectPathsOffsets(reader)[1] - item.SoftObjectPathsOffsets(reader)[0]}): SoftObjectPathList");
            item.SoftObjectPathList = reader.ReadList<FSoftObjectPath>(item.PackageFileSummary.SoftObjectPathsOffset, item.PackageFileSummary.SoftObjectPathsCount);
            GlobalObjects.SoftObjectPathList = item.SoftObjectPathList;
            item.SoftObjectPathList.AutoCheck("SoftObjectPathList", reader.BaseStream, item.SoftObjectPathsOffsets(reader));

            Log.Info($"[ 3] {item.GatherableOffsets(reader)[0]} - {item.GatherableOffsets(reader)[1]} ({item.GatherableOffsets(reader)[1] - item.GatherableOffsets(reader)[0]}): GatherableTextDataList");
            reader.BaseStream.Position = item.PackageFileSummary.GatherableTextDataOffset;
            item.GatherableTextDataList = reader.Read(item.GatherableTextDataList, item.PackageFileSummary.GatherableTextDataCount);
            item.GatherableTextDataList.AutoCheck("GatherableTextData", reader.BaseStream, item.GatherableOffsets(reader), (writer, obj) => writer.Write(obj));

            Log.Info($"[ 4] {item.ImportOffsets()[0]} - {item.ImportOffsets()[1]} ({item.ImportOffsets()[1] - item.ImportOffsets()[0]}): ImportMap");
            item.ImportMap = reader.ReadList<FObjectImport>(item.PackageFileSummary.ImportOffset, item.PackageFileSummary.ImportCount);
            item.ImportMap.AutoCheck("ImportMap", reader.BaseStream, item.ImportOffsets());

            Log.Info($"[ 5] {item.ExportOffsets()[0]} - {item.ExportOffsets()[1]} ({item.ExportOffsets()[1] - item.ExportOffsets()[0]}): ExportMap");
            reader.BaseStream.Position = item.PackageFileSummary.ExportOffset;
            item.ExportMap = reader.Read(item.ExportMap, item.PackageFileSummary.ExportCount);
            GlobalObjects.ExportMap = item.ExportMap;
            item.ExportMap.AutoCheck("ExportMap", reader.BaseStream, item.ExportOffsets(), (writer, obj) => writer.Write(obj));

            Log.Info($"[ 6] {item.DependsOffsets()[0]} - {item.DependsOffsets()[1]} ({item.DependsOffsets()[1] - item.DependsOffsets()[0]}): DependsMap");
            item.DependsMap = new() { Map = reader.ReadList<DependsMap.PackageIndexes>(item.PackageFileSummary.DependsOffset, item.PackageFileSummary.ExportCount) };
            item.DependsMap.AutoCheck("Depends", reader.BaseStream, item.DependsOffsets());

            Log.Info($"[ 7] {item.SoftPackageReferenceOffsets(reader)[0]} - {item.SoftPackageReferenceOffsets(reader)[1]} ({item.SoftPackageReferenceOffsets(reader)[1] - item.SoftPackageReferenceOffsets(reader)[0]}): SoftPackageReferenceList");
            item.SoftPackageReferenceList = reader.ReadList<FName>(-1, item.PackageFileSummary.SoftPackageReferencesCount);
            item.SoftPackageReferenceList.AutoCheck("SoftPackageReferenceList", reader.BaseStream, item.SoftPackageReferenceOffsets(reader));

            Log.Info($"[ 8] {item.SearchableNamesOffsets(reader)[0]} - {item.SearchableNamesOffsets(reader)[1]} ({item.SearchableNamesOffsets(reader)[1] - item.SearchableNamesOffsets(reader)[0]}): SearchableNamesMap");
            reader.BaseStream.Position = item.PackageFileSummary.SearchableNamesOffset > 0 ? item.PackageFileSummary.SearchableNamesOffset : reader.BaseStream.Position;
            item.SearchableNamesMap = reader.Read(item.SearchableNamesMap, item.PackageFileSummary.SearchableNamesOffset);
            item.SearchableNamesMap.AutoCheck("SearchableNames", reader.BaseStream, item.SearchableNamesOffsets(reader), (writer, obj) => writer.Write(obj));

            Log.Info($"[ 9] {item.ThumbnailsOffsets(reader)[0]} - {item.ThumbnailsOffsets(reader)[1]} ({item.ThumbnailsOffsets(reader)[1] - item.ThumbnailsOffsets(reader)[0]}): Thumbnails");
            item.Thumbnails = reader.Read(item.Thumbnails, item.PackageFileSummary.ThumbnailTableOffset);
            item.Thumbnails.AutoCheck("Thumbnails", reader.BaseStream, item.ThumbnailsOffsets(), (writer, obj) => writer.Write(obj));

            Log.Info($"[10] {item.ThumbnailTableOffsets()[0]} - {item.ThumbnailTableOffsets()[1]} ({item.ThumbnailTableOffsets()[1] - item.ThumbnailTableOffsets()[0]}): ObjectNameToFileOffsetMap");
            reader.BaseStream.Position = item.PackageFileSummary.ThumbnailTableOffset;
            item.ObjectNameToFileOffsetMap = reader.Read(item.ObjectNameToFileOffsetMap);
            item.ObjectNameToFileOffsetMap.AutoCheck("ThumbnailTable", reader.BaseStream, item.ThumbnailTableOffsets());

            Log.Info($"[11] {item.AssetRegistryDataOffsets()[0]} - {item.AssetRegistryDataOffsets()[1]} ({item.AssetRegistryDataOffsets()[1] - item.AssetRegistryDataOffsets()[0]}): AssetRegistryData");
            reader.BaseStream.Position = item.PackageFileSummary.AssetRegistryDataOffset;
            item.AssetRegistryData = reader.Read(item.AssetRegistryData);
            item.AssetRegistryData.AutoCheck("AssetRegistryData", reader.BaseStream, item.AssetRegistryDataOffsets(), (writer, obj) => writer.Write(obj));

            reader.Read(ref item.Pad, item.PackageFileSummary.TotalHeaderSize - reader.BaseStream.Position);
        }
    }
}
