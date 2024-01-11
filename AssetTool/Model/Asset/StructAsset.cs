namespace AssetTool
{
    public class StructAsset
    {
        public StructHeader Header = new();
        public List<AssetObject> Objects = new();
        public StructFooter Footer = new();
    }

    public static class StructAssetExt
    {
        public static void Write(this BinaryWriter writer, StructAsset item)
        {
            writer.Write(item.Header);

            foreach (var obj in item.Objects)
            {
                writer.BaseStream.Position = obj.Offset;
                writer.WriteObject(obj.Type, obj);
            }

            writer.Write(item.Footer);
        }

        public static void Read(this BinaryReader reader, StructAsset item)
        {
            reader.Read(item.Header);

            item.Objects = item.Header.ExportMap.Select(x => new AssetObject
            {
                Offset = x.SerialOffset,
                Size = x.SerialSize,
                Type = x.ClassIndex.Index < 0 ?
                    item.Header.ImportMap[-x.ClassIndex.Index - 1].ObjectName.Value :
                    item.Header.ExportMap[+x.ClassIndex.Index + 0].ObjectName.Value
            })
            .ToList();

            foreach (AssetObject obj in item.Objects)
            {
                reader.BaseStream.Position = obj.Offset;
                reader.ReadObject(obj.Type, obj);
            }

            reader.Read(item.Footer);
        }
    }
}
