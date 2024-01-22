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
                writer.WriteAssetObject(obj.Type, obj);
            }

            writer.Write(item.Footer);
        }

        public static void Read(this BinaryReader reader, StructAsset item)
        {
            reader.Read(item.Header);
            SetupObjects(item);
            PrintTypes(item);

            foreach (AssetObject obj in item.Objects)
            {
                reader.BaseStream.Position = obj.Offset;
                reader.ReadAssetObject(obj.Type, obj);
            }

            reader.Read(item.Footer);
        }

        private static void SetupObjects(StructAsset item)
        {
            item.Objects = item.Header.ExportMap.Select(x => new AssetObject
            {
                Offset = x.SerialOffset,
                Size = x.SerialSize,
                Type = x.ClassIndex.Index < 0 ?
                    item.Header.ImportMap[-x.ClassIndex.Index - 1].ObjectName.Value :
                    item.Header.ExportMap[+x.ClassIndex.Index + 0].ObjectName.Value
            })
            .ToList();
        }

        private static void PrintTypes(StructAsset item)
        {
            item.Objects.Select(x => x.Type).Distinct().ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
