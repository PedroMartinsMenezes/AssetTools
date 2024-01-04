namespace AssetTool
{
    public class FObjectImport
    {
        //FObjectResource
        public FName ObjectName = new();
        public FPackageIndex OuterIndex = new();
        //FObjectImport
        public FName ClassPackage = new();
        public FName ClassName = new();
        public FName PackageName = new();
        public Int32 SourceIndex;
        public FBool bImportOptional;
    }

    public static class ObjectImportExt
    {
        public static void Write(this BinaryWriter writer, FObjectImport item)
        {
            writer.Write(item.ClassPackage);
            writer.Write(item.ClassName);
            writer.Write(item.OuterIndex);
            writer.Write(item.ObjectName);
            writer.Write(item.PackageName);
            writer.Write(item.bImportOptional);
        }

        public static List<FObjectImport> ReadImportMap(this BinaryReader reader, int offset, int count)
        {
            reader.BaseStream.Position = offset;
            return Enumerable.Range(0, count).Select(x => reader.Read(new FObjectImport())).ToList();
        }

        public static FObjectImport Read(this BinaryReader reader, FObjectImport item)
        {
            reader.Read(item.ClassPackage);
            reader.Read(item.ClassName);
            reader.ReadPackageIndex(item.OuterIndex);
            reader.Read(item.ObjectName);
            reader.Read(item.PackageName);
            reader.Read(ref item.bImportOptional);
            return item;
        }
    }
}
