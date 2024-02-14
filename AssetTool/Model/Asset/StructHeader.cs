namespace AssetTool
{
    public class StructHeader
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
        public AssetRegistryData AssetRegistryData;
        public PadData Pad;
    }

    public static class StructHeaderExt
    {
        public static void Write(this BinaryWriter writer, StructHeader item)
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

        public static void Read(this BinaryReader reader, StructHeader item)
        {
            item.PackageFileSummary = reader.ReadValue(item.PackageFileSummary, item.GetType().GetField("PackageFileSummary"));
            item.NameMap = reader.ReadList<FNameEntrySerialized>(item.PackageFileSummary.NameOffset, item.PackageFileSummary.NameCount);
            GlobalNames.Set(item.NameMap);
            item.SoftObjectPathList = reader.ReadList<FSoftObjectPath>(item.PackageFileSummary.SoftObjectPathsOffset, item.PackageFileSummary.SoftObjectPathsCount);
            GlobalObjects.SoftObjectPathList = item.SoftObjectPathList;
            item.GatherableTextDataList = reader.ReadList<FGatherableTextData>(item.PackageFileSummary.GatherableTextDataOffset, item.PackageFileSummary.GatherableTextDataCount);
            item.ImportMap = reader.ReadList<FObjectImport>(item.PackageFileSummary.ImportOffset, item.PackageFileSummary.ImportCount);
            item.ExportMap = reader.ReadList<FObjectExport>(item.PackageFileSummary.ExportOffset, item.PackageFileSummary.ExportCount);
            GlobalObjects.ExportMap = item.ExportMap;
            item.DependsMap = new() { Map = reader.ReadList<DependsMap.PackageIndexes>(item.PackageFileSummary.DependsOffset, item.PackageFileSummary.ExportCount) };
            reader.BaseStream.Position = item.PackageFileSummary.SearchableNamesOffset;
            item.SearchableNamesMap = reader.ReadValue(item.SearchableNamesMap, item.GetType().GetField("SearchableNamesMap"));
            reader.BaseStream.Position = item.PackageFileSummary.ThumbnailTableOffset;
            item.ObjectNameToFileOffsetMap = reader.Read(item.ObjectNameToFileOffsetMap);
            reader.BaseStream.Position = item.PackageFileSummary.AssetRegistryDataOffset;
            item.AssetRegistryData = reader.ReadValue(item.AssetRegistryData, item.GetType().GetField("AssetRegistryData"));
            reader.Read(ref item.Pad, item.PackageFileSummary.TotalHeaderSize - reader.BaseStream.Position);
        }
    }
}
