namespace AssetTool
{
    public class StructAsset
    {
        public StructHeader Header = new();

        public StructFooter Pad;

        public List<AssetObject> Objects = new();

        public StructFooter Footer;
    }

    public static class StructAssetExt
    {
        public static void Write(this BinaryWriter writer, StructAsset item)
        {
            try
            {
                writer.Write(item.Header); //28680 OK

                writer.Write(item.Pad);

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
                PrintTypes(item);

                reader.Read(ref item.Pad, item.Objects[i].Offset - reader.BaseStream.Position);

                for (i = 0; i < item.Objects.Count; i++)
                {
                    AssetObject obj = item.Objects[i];
                    Log.Info($"[{i + 1}] {obj.Offset} - {obj.NextOffset} ({obj.Size}): {obj.Type}");
                    reader.BaseStream.Position = obj.Offset;
                    reader.ReadAssetObject(obj.Type, obj);
                    CheckPosition(reader, item, i, obj);
                    CheckData(reader, obj);
                }

                reader.Read(ref item.Footer);
            }
            catch (Exception ex)
            {
                item.Objects.RemoveRange(i, item.Objects.Count - i - 1);
                Log.Info($"Error at {reader.BaseStream.Position}");
                Log.Info(ex.Message);
            }
        }

        private static void CheckPosition(BinaryReader reader, StructAsset item, int i, AssetObject obj)
        {
            if (obj.NextOffset != reader.BaseStream.Position)
            {
                item.Objects.RemoveRange(i, item.Objects.Count - i - 1);
                Log.Info($"Wrong Read Size. Expected NextOffset {obj.NextOffset}. Actual {reader.BaseStream.Position}");
                throw new InvalidOperationException();
            }
        }

        private static void CheckData(BinaryReader reader, AssetObject obj)
        {
            long pos = reader.BaseStream.Position;

            MemoryStream stream = new();
            BinaryWriter writer = new BinaryWriter(stream);

            writer.WriteAssetObject(obj.Type, obj);

            long createdSize = stream.Length;
            long originalSize = obj.NextOffset - obj.Offset;

            if (createdSize != originalSize)
            {
                Log.Info($"Wrong Write Size. Expected {originalSize}. Actual {createdSize}");
                throw new InvalidOperationException();
            }
            byte[] createdBytes = new byte[originalSize];
            stream.Seek(0, SeekOrigin.Begin);
            stream.Read(createdBytes);

            byte[] originalBytes = new byte[originalSize];
            reader.BaseStream.Position = obj.Offset;
            reader.Read(originalBytes);

            for (int i = 0; i < originalSize; i++)
            {
                byte expected = originalBytes[i];
                byte actual = originalBytes[i];
                if (expected != actual)
                {
                    Log.Info($"Wrong Write Value at {i}");
                    throw new InvalidOperationException();
                }
            }
            reader.BaseStream.Position = pos;
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
        }

        private static void PrintTypes(StructAsset item)
        {
            Log.Info("List os Objects:");
            Log.Info("");
            item.Objects.Select((x, i) => (x.Type, i + 1)).Distinct().ToList().ForEach(x => Log.Info($"[{x.Item2}] {x.Item1}"));
            Log.Info("");
            Log.Info("Reading Objects:");
            Log.Info("");
        }
    }
}
