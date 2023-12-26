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
            writer.Write(item.A);
            writer.Write(item.B);
            writer.Write(item.C);
            writer.Write(item.D.Index);
        }
    }
}
