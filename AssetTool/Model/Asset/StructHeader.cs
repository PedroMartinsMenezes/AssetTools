namespace AssetTool
{
    //0..2777
    public class StructHeader
    {
        public FPackageFileSummary PackageFileSummary; //0..406
        public List<FNameEntrySerialized> NameMap = new(); //406..2060
        public List<FSoftObjectPath> SoftObjectPathList = new(); //2060..2080
        public List<FGatherableTextData> GatherableTextDataList = new(); //2080..2080
        public List<FObjectImport> ImportMap = new(); //2080..2320
        public List<FObjectExport> ExportMap = new(); //2320..2608
        public DependsMap DependsMap = new(); //2608..2620
        public SearchableNamesMap SearchableNamesMap = new(); //2620..2624
        public ThumbnailTable ObjectNameToFileOffsetMap = new(); //2636..2681
        public AssetRegistryData AssetRegistryData = new(); //2681..2777
    }

    public static class StructHeaderExt
    {
        public static void Write(this BinaryWriter writer, StructHeader item)
        {
            //Pos 0..406
            writer.WriteValue(item.PackageFileSummary); //OK
            //Pos 406..2060
            writer.WriteValue(item.NameMap); //OK
            //Pos 2060..2080
            writer.WriteValue(item.SoftObjectPathList); //OK
            //Pos 2080..2080
            writer.WriteValue(item.GatherableTextDataList); //OK
            //Pos 2080..2320
            writer.WriteValue(item.ImportMap); //OK
            //Pos 2320..2608
            writer.WriteValue(item.ExportMap); //OK
            //Pos 2608..2620
            writer.Write(item.DependsMap);
            //Pos 2620..2624
            writer.Write(item.SearchableNamesMap);
            //Pos 2624..2636
            //zeros ?
            //2636..2681
            writer.Write(item.ObjectNameToFileOffsetMap, item.PackageFileSummary.ThumbnailTableOffset);
            //Pos 2681..2777
            writer.Write(item.AssetRegistryData, item.PackageFileSummary.AssetRegistryDataOffset);
        }

        public static void Read(this BinaryReader reader, StructHeader item)
        {
            //Pos 0..406
            item.PackageFileSummary = reader.ReadValue(item.PackageFileSummary); //OK
            //Pos 406..2060
            reader.BaseStream.Position = item.PackageFileSummary.NameOffset;
            item.NameMap = reader.ReadList<FNameEntrySerialized>(item.PackageFileSummary.NameOffset, item.PackageFileSummary.NameCount); //OK
            GlobalNames.Set(item.NameMap);
            //Pos 2060..2080
            item.SoftObjectPathList = reader.ReadList<FSoftObjectPath>(item.PackageFileSummary.SoftObjectPathsOffset, item.PackageFileSummary.SoftObjectPathsCount); //OK
            //Pos 2080..2080
            item.GatherableTextDataList = reader.ReadList<FGatherableTextData>(item.PackageFileSummary.GatherableTextDataOffset, item.PackageFileSummary.GatherableTextDataCount); //OK
            //Pos 2080..2320            
            item.ImportMap = reader.ReadList<FObjectImport>(item.PackageFileSummary.ImportOffset, item.PackageFileSummary.ImportCount); //OK
            //Pos 2320..2608            
            item.ExportMap = reader.ReadList<FObjectExport>(item.PackageFileSummary.ExportOffset, item.PackageFileSummary.ExportCount); //OK
            //Pos 2608..2620
            item.DependsMap = reader.ReadDependsMap(item.PackageFileSummary.DependsOffset, item.PackageFileSummary.ExportCount);
            //Pos 2620..2624
            item.SearchableNamesMap = reader.ReadSearchableNamesMap(item.PackageFileSummary.SearchableNamesOffset);
            //Pos 2636..2681
            item.ObjectNameToFileOffsetMap = reader.ReadThumbnailTable(item.PackageFileSummary.ThumbnailTableOffset);
            //Pos 2681..2777
            item.AssetRegistryData = reader.ReadAssetRegistryData(item.PackageFileSummary.AssetRegistryDataOffset);
        }
    }
}
