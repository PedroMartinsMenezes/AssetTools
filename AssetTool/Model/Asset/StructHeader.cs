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
        //
        public SearchableNamesMap SearchableNamesMap = new(); //2620..2624
        
        public FObjectThumbnail ObjectThumbnail = new(); //2624..2640
        
        public ObjectNameToFileOffsetMap ObjectNameToFileOffsetMap = new(); //2636..2681

        public AssetRegistryData AssetRegistryData = new(); //2681..2765
    }

    public static class StructHeaderExt
    {
        public static void Write(this BinaryWriter writer, StructHeader item)
        {
            //Pos 0..406
            writer.Write(item.PackageFileSummary);
            //Pos 406..2060
            item.NameMap.ForEach(writer.Write);
            //Pos 2060..2080
            item.SoftObjectPathList.ForEach(writer.Write);
            //Pos 2080..2080
            item.GatherableTextDataList.ForEach(writer.Write);
            //Pos 2080..2320
            item.ImportMap.ForEach(writer.Write);
            //Pos 2320..2608
            item.ExportMap.ForEach(writer.Write);
            //Pos 2608..2620
            writer.Write(item.DependsMap);
            //Pos 2620..2624
            writer.Write(item.SearchableNamesMap);
        }

        public static void Read(this BinaryReader reader, StructHeader asset)
        {
            //Pos 0..406
            asset.PackageFileSummary = reader.Read(new FPackageFileSummary());
            //Pos 406..2060
            asset.NameMap = reader.ReadNameMap(asset.PackageFileSummary.NameOffset, asset.PackageFileSummary.NameCount);
            //Pos 2060..2080
            asset.SoftObjectPathList = reader.SoftObjectPathList(asset.PackageFileSummary.SoftObjectPathsOffset, asset.PackageFileSummary.SoftObjectPathsCount);
            //Pos 2080..2080
            asset.GatherableTextDataList = reader.GatherableTextDataList(asset.PackageFileSummary.GatherableTextDataOffset, asset.PackageFileSummary.GatherableTextDataCount);
            //Pos 2080..2320
            asset.ImportMap = reader.ReadImportMap(asset.PackageFileSummary.ImportOffset, asset.PackageFileSummary.ImportCount);
            //Pos 2320..2608
            asset.ExportMap = reader.ReadExportMap(asset.PackageFileSummary.ExportOffset, asset.PackageFileSummary.ExportCount);
            //Pos 2608..2620
            asset.DependsMap = reader.ReadDependsMap(asset.PackageFileSummary.DependsOffset, asset.PackageFileSummary.ExportCount);
            //Pos 2620..2624
            asset.SearchableNamesMap = reader.ReadSearchableNamesMap(asset.PackageFileSummary.SearchableNamesOffset);

            //Pos 2636..?
            //ThumbnailTableOffset

            #region
            //ThumbnailTable
            //TMap<FName, int32> ObjectNameToFileOffsetMap;
            //int count = reader.ReadInt32(); //1
            //FString ObjectShortClassName = reader.ReadFString(); //"UserDefinedStruct"
            //FString ObjectPathWithoutPackageName = reader.ReadFString(); //"S_Endereco"
            //Int32 FileOffset = reader.ReadInt32(); //2624
            #endregion

            //Pos 2681..2765
            asset.AssetRegistryData = reader.ReadAssetRegistryData(asset.PackageFileSummary.AssetRegistryDataOffset);
        }
    }
}
