using AssetTool.Model;

namespace AssetTool.Service
{
    public static class ObjectImportExt
    {
        public static void Write(this BinaryWriter writer, List<FObjectImport> list)
        {
            list.ForEach(item => writer.Write(item));
        }

        public static void Write(this BinaryWriter writer, FObjectImport item)
        {
            writer.WriteString(item.ClassPackage);
            writer.WriteString(item.ClassName);
            writer.Write(item.OuterIndex.Index);
            writer.WriteString(item.ObjectName);
            writer.WriteString(item.PackageName);
            writer.Write(item.bImportOptional);
        }

        public static void Add(this List<FObjectImport> list, string a, string b, int c, string d, string e, bool f)
        {
            list.Add(new() { ClassPackage = a, ClassName = b, OuterIndex = new() { Index = c }, ObjectName = d, PackageName = e, bImportOptional = f });
        }
    }
}
