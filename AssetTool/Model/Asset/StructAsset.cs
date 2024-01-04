using AssetTool.Model;

namespace AssetTool
{
    public class StructAsset
    {
        public StructHeader Header = new();
        public List<AssetObject> Objects = new();
    }

    public static class StructAssetExt
    {
        public static void Write(this BinaryWriter writer, StructAsset item)
        {
            writer.Write(item.Header);

            foreach (var obj in item.Objects)
            {
                writer.BaseStream.Position = obj.Offset;
                if (obj.Type == "PackageMetaData")
                {
                    writer.Write(obj.Metadata);
                }
            }
        }

        public static void Read(this BinaryReader reader, StructAsset item)
        {
            reader.Read(item.Header);

            item.Objects = item.Header.ExportMap.Select(x => new AssetObject
            {
                Offset = x.SerialOffset,
                Type = x.ObjectName.Value
            }).
            ToList();

            reader.Read(item.Objects);
        }
    }
}
