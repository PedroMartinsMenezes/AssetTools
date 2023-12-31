namespace AssetTool
{
    //0..2777
    public class StructHeader
    {
        public FPackageFileSummary PackageFileSummary; //0..406
        
        public List<FNameEntrySerialized> NameMap = new(); //406..2060
        
        public List<FSoftObjectPath> SoftObjectPath; //2060..2080
        
        public List<FGatherableTextData> GatherableTextDataList = new(); //2080..2080
        
        public List<FObjectImport> ImportMap = new(); //2080..2320

        public List<FObjectExport> ExportMap = new(); //2320..2608
        
        public DependsMap DependsMap = new(); //2608..2620
    }

    public static class StructHeaderExt
    {
        //C:\src\UnrealEngine\Engine\Source\Runtime\CoreUObject\Private\UObject\SavePackage2.cpp 1056
        //Função que escreve em arquivo: BuildLinker
        public static void Write(this BinaryWriter writer, StructHeader item)
        {
            //Pos 0..406
            writer.Write(item.PackageFileSummary);
            //Pos 406..2060
            item.NameMap.ForEach(writer.Write);
            //Pos 2060..2080
            item.SoftObjectPath.ForEach(writer.Write);
            //Pos 2080..2080
            item.GatherableTextDataList.ForEach(writer.Write);
            //Pos 2080..2320
            item.ImportMap.ForEach(writer.Write);
            //Pos 2320..2608
            item.ExportMap.ForEach(writer.Write);
            //Pos 2608..2620
            writer.Write(item.DependsMap);

            //C:\src\UnrealEngine\Engine\Source\Runtime\CoreUObject\Private\UObject\Linker.cpp 204
            //Ar << ImportMap;
            //Ar << ExportMap;
            //Ar << DependsMap;
            //Ar << SoftPackageReferenceList;
            //Ar << GatherableTextDataMap;
            //Ar << SearchableNamesMap;
        }

        public static void Read(this BinaryReader reader, StructHeader asset)
        {
            //Pos 0..406
            asset.PackageFileSummary = reader.Read(new FPackageFileSummary());
            //Pos 406..2060
            asset.NameMap = reader.ReadList(asset.PackageFileSummary.NameCount, new FNameEntrySerialized());
            //Pos 2060..2080
            asset.SoftObjectPath = reader.ReadList(asset.PackageFileSummary.SoftObjectPathsCount, new FSoftObjectPath());
            //Pos 2080..2080
            asset.GatherableTextDataList = reader.ReadList(asset.PackageFileSummary.SoftObjectPathsCount, new FGatherableTextData());
            //Pos 2080..2320
            asset.ImportMap = reader.ReadList(asset.PackageFileSummary.ImportCount, new FObjectImport());
            //Pos 2320..2608
            asset.ExportMap = reader.ReadList(asset.PackageFileSummary.ExportCount, new FObjectExport());
            //Pos 2608..2620
            asset.DependsMap = reader.Read(asset.PackageFileSummary.ExportCount, new DependsMap());

            //Pos 2620..2620
            //SoftPackageReferenceList Empty
            //Pos 2620..2636
            //SearchableNames 16 bytes. TMap<FPackageIndex, TArray<FName> > SearchableNamesMap;
            //Pos 2636..?
            //ThumbnailTable
            //Pos = 2765
        }
    }
}
