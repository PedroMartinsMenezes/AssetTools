using AssetTool.Model.Basic;
using AssetTool.Service;

namespace AssetTool.Model
{
    //20 bytes. 2300..2320
    public class FTopLevelAssetPath
    {
        public FName PackageName;
        public FName AssetName;
    }

    public static class Gap1Ext
    {
        public static void Write(this BinaryWriter writer, FTopLevelAssetPath item)
        {
            writer.Write(item.PackageName);
            writer.WriteIncomplete(item.AssetName);
        }

        public static FTopLevelAssetPath Read(this BinaryReader reader, FTopLevelAssetPath item)
        {
            reader.Read(ref item.PackageName);
            reader.ReadIncomplete(ref item.AssetName);
            return item;
        }
    }
}
