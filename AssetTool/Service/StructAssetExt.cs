using AssetTool.Model;

namespace AssetTool.Service
{
    public static class StructAssetExt
    {
        public static void Write(this BinaryWriter writer, StructAsset item)
        {
            writer.Write(item.PackageFileSummary);
            writer.Write(item.NameMap);
            writer.Write(item.ImportMap);
            writer.WriteGap_2300_2320();
            writer.Write(item.ExportMap);
        }

        public static void WriteGap_2300_2320(this BinaryWriter writer)
        {
            writer.Write(new byte[] { 0x38, 0, 0, 0 });
            writer.Write(new byte[] { 0, 0, 0, 0 });
            writer.Write(new byte[] { 0x1d, 0, 0, 0 });
            writer.Write(new byte[] { 0, 0, 0, 0 });
            writer.Write(new byte[] { 0, 0, 0, 0 });
        }
    }
}
