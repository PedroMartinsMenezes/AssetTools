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
            try
            {
                writer.Write(item.Header); //28680 OK

                item.Objects = item.Objects.OrderBy(x => x.Offset).ToList();
                foreach (var obj in item.Objects)
                {
                    Log.Info($"Writing {obj.Type}");
                    writer.BaseStream.Position = obj.Offset; //69226..69271
                    writer.WriteAssetObject(obj.Type, obj);
                }

                writer.Write(item.Footer);
            }
            catch (Exception ex)
            {
                Log.Info(ex.ToString());
            }
        }

        public static void Read(this BinaryReader reader, StructAsset item)
        {
            int i = 0;
            try
            {
                reader.Read(item.Header);

                SetupObjects(item);

                for (i = 0; i < item.Objects.Count; i++)
                {
                    AssetObject obj = item.Objects[i];
                    Log.Info($"{obj.Offset} - {obj.NextOffset}: {obj.Type}");
                    reader.BaseStream.Position = obj.Offset;
                    reader.ReadAssetObject(obj.Type, obj);
                    if (obj.NextOffset != reader.BaseStream.Position)
                    {
                        item.Objects.RemoveRange(i, item.Objects.Count);
                        Log.Info($"Wrong size. Expected {obj.NextOffset}. Actual {reader.BaseStream.Position}");
                        throw new InvalidOperationException();
                    }
                }

                reader.Read(item.Footer);
            }
            catch (Exception ex)
            {
                item.Objects.RemoveRange(i, item.Objects.Count - i);
                Log.Info($"Error at {reader.BaseStream.Position}");
                Log.Info(ex.ToString());
            }
        }

        private static void SetupObjects(StructAsset item)
        {
            if (item.Header.ExportMap is null)
                return;
            item.Objects = item.Header.ExportMap.Select(x => new AssetObject
            {
                Offset = x.SerialOffset,
                Size = x.SerialSize,
                Type = x.ClassIndex.Index < 0 ?
                    item.Header.ImportMap[-x.ClassIndex.Index - 1].ObjectName.Value :
                    item.Header.ExportMap[+x.ClassIndex.Index + 0].ObjectName.Value
            })
            .ToList();

            PrintTypes(item);
        }

        private static void PrintTypes(StructAsset item)
        {
            Log.Info("Objects:");
            item.Objects.Select(x => x.Type).Distinct().ToList().ForEach(x => Log.Info(x));
            Log.Info("");
            Log.Info("Reading:");
        }
    }
}
