using System.Linq;
using System.Reflection.PortableExecutable;
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
        public List<FObjectThumbnail> Thumbnails;
        public AssetRegistryData AssetRegistryData; //2681..2777
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
            writer.WriteValue(item.DependsMap); //OK
            //Pos 2620..2624
            writer.WriteValue(item.SearchableNamesMap); //OK
            //Pos 2624..2636
            //zeros ?
            //2636..2681
            writer.BaseStream.Position = item.PackageFileSummary.ThumbnailTableOffset;
            writer.WriteValue(item.ObjectNameToFileOffsetMap); //OK
            writer.WriteThumbnails(item);
            //Pos 2681..2777
            writer.BaseStream.Position = item.PackageFileSummary.AssetRegistryDataOffset;
            writer.WriteValue(item.AssetRegistryData); //OK
        }

        public static void Read(this BinaryReader reader, StructHeader item)
        {
            //Pos 0..406
            item.PackageFileSummary = reader.ReadValue(item.PackageFileSummary); //OK
            //Pos 406..2060
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
            item.DependsMap = new() { Map = reader.ReadList<DependsMap.PackageIndexes>(item.PackageFileSummary.DependsOffset, item.PackageFileSummary.ExportCount) }; //OK
            //Pos 2620..2624
            reader.BaseStream.Position = item.PackageFileSummary.SearchableNamesOffset;
            item.SearchableNamesMap = reader.ReadValue(item.SearchableNamesMap); //OK
            //Pos 2636..2681
            reader.BaseStream.Position = item.PackageFileSummary.ThumbnailTableOffset;
            item.ObjectNameToFileOffsetMap = reader.ReadValue(item.ObjectNameToFileOffsetMap); //OK
            reader.ReadThumbnails(item);
            //Pos 2681..2777
            reader.BaseStream.Position = item.PackageFileSummary.AssetRegistryDataOffset;
            item.AssetRegistryData = reader.ReadValue(item.AssetRegistryData); //OK
        }

        private static void ReadThumbnails(this BinaryReader reader, StructHeader header)
        {
            header.Thumbnails = new();
            foreach (object value in header.ObjectNameToFileOffsetMap.Map.Values)
            {
                int offset = (int)value;
                reader.BaseStream.Position = offset;
                header.Thumbnails.Add(reader.ReadValue(new FObjectThumbnail()));
            }
        }

        private static void WriteThumbnails(this BinaryWriter writer, StructHeader header)
        {
            int i = 0;
            foreach (object value in header.ObjectNameToFileOffsetMap.Map.Values)
            {
                int offset = (int)value;
                writer.BaseStream.Position = offset;
                writer.WriteValue(header.Thumbnails[i]);
            }
        }
    }
}
