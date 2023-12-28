using AssetTool.Model;

namespace AssetTool.Service
{
    public static class StructAssetExt
    {
        public static void Write(this BinaryWriter writer, StructAsset item, string referencePath)
        {
            writer.Write(item.PackageFileSummary);
            writer.Write(item.NameMap);
            writer.Write(item.ImportMap);
            writer.WriteGap(2320 - writer.BaseStream.Position, referencePath);
            writer.Write(item.ExportMap);
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
