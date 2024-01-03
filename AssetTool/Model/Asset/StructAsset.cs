namespace AssetTool
{
    public class StructAsset
    {
        public StructHeader Header = new();
        public List<StructBody> Objects = new();
    }

    public static class StructAssetExt
    {
        public static void Write(this BinaryWriter writer, StructAsset item)
        {
            writer.Write(item.Header);
            item.Objects.ForEach(writer.Write);
        }

        public static void Read(this BinaryReader reader, StructAsset item)
        {
            reader.Read(item.Header);

            foreach (var export in item.Header.ExportMap)
            {
                item.Objects.Add(reader.Read(new StructBody { Offset = (int)export.SerialOffset }));
            }
        }
    }
}
