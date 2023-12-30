using AssetTool.Model;

namespace AssetTool.Service
{
    public static class StructHeaderExt
    {
        public static void Write(this BinaryWriter writer, StructHeader item, string referencePath)
        {
            writer.Write(item.PackageFileSummary);
            item.NameMap.ForEach(writer.Write);
            item.ImportMap.ForEach(writer.Write);
            writer.WriteGap(20, referencePath);
            item.ExportMap.ForEach(writer.Write);
            writer.WriteGap(2681 - writer.BaseStream.Position, referencePath);
            writer.Write(item.PackageDataMain);
            writer.Write(item.OutImportUsedInGame);
            writer.Write(item.OutSoftPackageUsedInGame);
        }

        public static void WriteGap(this BinaryWriter writer, long count, string referencePath)
        {
            byte[] bytes = new byte[count];
            using var stream = new FileStream(referencePath, FileMode.Open);
            stream.Position = writer.BaseStream.Position;
            using var reader = new BinaryReader(stream);
            reader.Read(bytes, 0, (int)count);
            writer.Write(bytes);
        }
    }
}
