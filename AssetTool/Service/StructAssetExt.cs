using AssetTool.Model;

namespace AssetTool.Service
{
    public static class StructAssetExt
    {
        public static void Write(this BinaryWriter writer, StructAsset item)
        {
            writer.Write(item.PackageFileSummary);
            writer.Write(item.NameMap);
        }
    }
}
