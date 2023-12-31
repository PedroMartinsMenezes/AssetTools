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

        public static List<FObjectImport> ReadList(this BinaryReader reader, int count, FObjectImport item)
        {
            return Enumerable.Range(0, count).Select(x => reader.Read(new FObjectImport())).ToList();
        }

        public static FObjectImport Read(this BinaryReader reader, FObjectImport item)
        {
            reader.Read(ref item.ClassPackage);
            reader.Read(ref item.ClassName);
            reader.Read(item.OuterIndex);
            reader.Read(ref item.ObjectName);
            reader.Read(ref item.PackageName);
            reader.Read(ref item.bImportOptional);
            return item;
        }
    }
}
