using AssetTool.Model;

namespace AssetTool.Service
{
    public static class ObjectImportExt
    {
        public static void Write(this BinaryWriter writer, FObjectImport item)
        {
            writer.Write(item.PackageName);
            writer.Write(item.ClassPackage);
            writer.Write(item.ClassName);
            writer.Write(item.OuterIndex.Index);
        }

        public static FObjectImport Read(this BinaryReader reader, FObjectImport item)
        {
            reader.Read(ref item.PackageName);
            reader.Read(ref item.ClassPackage);
            reader.Read(ref item.ClassName);
            reader.Read(ref item.OuterIndex);
            return item;
        }

        public static List<FObjectImport> ReadList(this BinaryReader reader, int count, FObjectImport item)
        {
            return Enumerable.Range(0, count).Select(x => reader.Read(new FObjectImport())).ToList();
        }
    }
}
