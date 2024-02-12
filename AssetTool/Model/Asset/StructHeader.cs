namespace AssetTool
{
    //0..2777
    public class StructHeader
    {
        public FPackageFileSummary PackageFileSummary; //0..406
        public List<FNameEntrySerialized> NameMap; //406..2060
        public List<FSoftObjectPath> SoftObjectPathList; //2060..2080
        public List<FGatherableTextData> GatherableTextDataList; //2080..2080
        public List<FObjectImport> ImportMap; //2080..2320
        public List<FObjectExport> ExportMap; //2320..2608
        public DependsMap DependsMap; //2608..2620
        public SearchableNamesMap SearchableNamesMap; //2620..2624
        public ThumbnailTable ObjectNameToFileOffsetMap; //2636..2681
        public AssetRegistryData AssetRegistryData; //2681..2777
    }

    public static class StructHeaderExt
    {
        public static void Write(this BinaryWriter writer, StructHeader item)
        {
            //Pos 0..406
            writer.WriteValue(ref item.PackageFileSummary, item.GetType().GetField("PackageFileSummary"));
            //Pos 406..2060
            writer.WriteValue(ref item.NameMap, item.GetType().GetField("NameMap"));
            //Pos 2060..2080
            writer.WriteValue(ref item.SoftObjectPathList, item.GetType().GetField("SoftObjectPathList"));
            //Pos 2080..2080
            writer.WriteValue(ref item.GatherableTextDataList, item.GetType().GetField("GatherableTextDataList"));
            //Pos 2080..2320
            writer.WriteValue(ref item.ImportMap, item.GetType().GetField("ImportMap"));
            //Pos 2320..2608
            writer.WriteValue(ref item.ExportMap, item.GetType().GetField("ExportMap"));
            //Pos 2608..2620
            writer.WriteValue(ref item.DependsMap, item.GetType().GetField("DependsMap"));
            //Pos 2620..2624
            writer.WriteValue(ref item.SearchableNamesMap, item.GetType().GetField("SearchableNamesMap"));
            //Pos 2624..2636
            //zeros ?
            //2636..2681
            writer.BaseStream.Position = item.PackageFileSummary.ThumbnailTableOffset;
            writer.Write(item.ObjectNameToFileOffsetMap);
            //Pos 2681..2777
            writer.BaseStream.Position = item.PackageFileSummary.AssetRegistryDataOffset;
            writer.WriteValue(item.AssetRegistryData, item.GetType().GetField("AssetRegistryData"));
        }

        public static void Read(this BinaryReader reader, StructHeader item)
        {
            //Pos 0..406
            item.PackageFileSummary = reader.ReadValue(item.PackageFileSummary, item.GetType().GetField("PackageFileSummary"));
            //os 406..2060
            item.NameMap = reader.ReadList<FNameEntrySerialized>(item.PackageFileSummary.NameOffset, item.PackageFileSummary.NameCount);
            GlobalNames.Set(item.NameMap);
            //Pos 2060..2080
            item.SoftObjectPathList = reader.ReadList<FSoftObjectPath>(item.PackageFileSummary.SoftObjectPathsOffset, item.PackageFileSummary.SoftObjectPathsCount);
            GlobalObjects.SoftObjectPathList = item.SoftObjectPathList;
            //Pos 2080..2080
            item.GatherableTextDataList = reader.ReadList<FGatherableTextData>(item.PackageFileSummary.GatherableTextDataOffset, item.PackageFileSummary.GatherableTextDataCount);
            //Pos 2080..2320            
            item.ImportMap = reader.ReadList<FObjectImport>(item.PackageFileSummary.ImportOffset, item.PackageFileSummary.ImportCount);
            //Pos 2320..2608            
            item.ExportMap = reader.ReadList<FObjectExport>(item.PackageFileSummary.ExportOffset, item.PackageFileSummary.ExportCount);
            GlobalObjects.ExportMap = item.ExportMap;
            //Pos 2608..2620
            item.DependsMap = new() { Map = reader.ReadList<DependsMap.PackageIndexes>(item.PackageFileSummary.DependsOffset, item.PackageFileSummary.ExportCount) };
            //Pos 2620..2624
            reader.BaseStream.Position = item.PackageFileSummary.SearchableNamesOffset;
            item.SearchableNamesMap = reader.ReadValue(item.SearchableNamesMap, item.GetType().GetField("SearchableNamesMap"));
            //Pos 2636..2681
            reader.BaseStream.Position = item.PackageFileSummary.ThumbnailTableOffset;
            item.ObjectNameToFileOffsetMap = reader.Read(item.ObjectNameToFileOffsetMap);
            //Pos 2681..2777
            reader.BaseStream.Position = item.PackageFileSummary.AssetRegistryDataOffset;
            item.AssetRegistryData = reader.ReadValue(item.AssetRegistryData, item.GetType().GetField("AssetRegistryData"));
        }
    }
}
