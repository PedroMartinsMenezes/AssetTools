using AssetTool.Model;

namespace AssetTool
{
    public class AssetObject
    {
        public long Offset;
        public string Type;

        //polymorphic members
        public UMetadata Metadata;
    }

    public static class StructBodyExt
    {
        public static void Write(this BinaryWriter writer, AssetObject item)
        {
            writer.BaseStream.Position = item.Offset;
            writer.Write(item.Metadata);
        }

        public static void Read(this BinaryReader reader, List<AssetObject> list) =>
            list.ForEach(x => reader.Read(x));

        public static AssetObject Read(this BinaryReader reader, AssetObject item)
        {
            reader.BaseStream.Position = item.Offset;
            if (item.Type == "PackageMetaData")
            {
                item.Metadata = new();
                reader.Read(item.Metadata);
            }
            return item;
        }
    }
}
