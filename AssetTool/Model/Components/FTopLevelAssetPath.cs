namespace AssetTool
{
    //20 bytes. 2300..2320
    public class FTopLevelAssetPath
    {
        public FName PackageName = new();
        public FName AssetName = new();
    }

    public static class FTopLevelAssetPathExt
    {
        public static void Write(this BinaryWriter writer, FTopLevelAssetPath item)
        {
            writer.Write(item.PackageName);
            writer.Write(item.AssetName);
        }

        public static FTopLevelAssetPath Read(this BinaryReader reader, FTopLevelAssetPath item)
        {
            reader.Read(ref item.PackageName);
            reader.Read(ref item.AssetName);
            return item;
        }
    }
}
