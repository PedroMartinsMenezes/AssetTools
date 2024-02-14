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
            int i = 0;
            try
            {
                writer.Write(item.Header);

                writer.Write(item.Pad);

                item.Objects = item.Objects.OrderBy(x => x.Offset).ToList();
                for (i = 0; i < item.Objects.Count; i++)
                {
                    AssetObject obj = item.Objects[i];
                    Log.Info($"[{i + 1}] {obj.Offset} - {obj.NextOffset} ({obj.Size}): {obj.Type}");
                    writer.BaseStream.Position = obj.Offset;
                    writer.WriteAssetObject(obj.Type, obj);
                    CheckWriterPosition(writer, item, i, obj);
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
                Log.Info("\nReading Asset\n");
                reader.Read(item.Header);

                SetupObjects(item);

                long padSize = item.Objects[i].Offset - reader.BaseStream.Position;
                Log.Info($"\nReading Pad Data: {padSize} bytes\n");
                reader.Read(ref item.Pad, padSize);

                CheckHeaderReaderPosition(reader, item.Header);

                for (i = 0; i < item.Objects.Count; i++)
                {
                    AssetObject obj = item.Objects[i];
                    Log.Info($"[{i + 1}] {obj.Offset} - {obj.NextOffset} ({obj.Size}): {obj.Type}");
                    reader.BaseStream.Position = obj.Offset;
                    reader.ReadAssetObject(obj.Type, obj);
                    CheckReaderPosition(reader, item, i, obj);
                    CheckReaderData(reader, obj);
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

        private static void CheckHeaderReaderPosition(BinaryReader reader, StructHeader obj)
        {
            if (obj.PackageFileSummary.TotalHeaderSize != reader.BaseStream.Position)
            {
                Log.Info($"Wrong StructHeader Read Size. Expected NextOffset {obj.PackageFileSummary.TotalHeaderSize}. Actual {reader.BaseStream.Position}");
                throw new InvalidOperationException();
            }
        }

        private static void CheckReaderPosition(BinaryReader reader, StructAsset item, int i, AssetObject obj)
        {
            if (obj.NextOffset != reader.BaseStream.Position)
            {
                item.Objects.RemoveRange(i, item.Objects.Count - i - 1);
                Log.Info($"Wrong Read Size. Expected NextOffset {obj.NextOffset}. Actual {reader.BaseStream.Position}");
                throw new InvalidOperationException();
            }
        }

        private static void CheckWriterPosition(BinaryWriter writer, StructAsset item, int i, AssetObject obj)
        {
            if (obj.NextOffset != writer.BaseStream.Position)
            {
                item.Objects.RemoveRange(i, item.Objects.Count - i - 1);
                Log.Info($"Wrong Write Size. Expected NextOffset {obj.NextOffset}. Actual {writer.BaseStream.Position}");
                throw new InvalidOperationException();
            }
        }

        private static void CheckReaderData(BinaryReader reader, AssetObject obj)
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
    }
}
