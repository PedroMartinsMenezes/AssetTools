namespace AssetTool
{
    public class StructAsset
    {
        public AssetHeader Header = new();

        public List<AssetObject> Objects = new();

        public PadData Footer;
    }

    public static class StructAssetExt
    {
        public static void Write(this BinaryWriter writer, StructAsset item)
        {
            int i = 0;
            try
            {
                writer.Write(item.Header);

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

        public static bool Read(this BinaryReader reader, StructAsset item)
        {
            int i = 0;
            try
            {
                ReadHeader(reader, item.Header);
                CheckAssetHeader(reader, item.Header);
                SetupObjects(item);

                for (i = 0; i < item.Objects.Count; i++)
                {
                    AssetObject obj = item.Objects[i];
                    Log.Info($"[{i + 1}] {obj.Offset} - {obj.NextOffset} ({obj.Size}): {obj.Type}");
                    reader.BaseStream.Position = obj.Offset;
                    reader.ReadAssetObject(obj.Type, obj);
                    CheckAssetObject(reader, obj);
                }

                reader.Read(ref item.Footer);
                return true;
            }
            catch (Exception ex)
            {
                if (item.Objects.Count > 0) item.Objects.RemoveRange(i, item.Objects.Count - i - 1);
                Log.Info($"Error at {reader.BaseStream.Position}");
                Log.Info(ex.Message);
                return false;
            }
        }

        private static void ReadHeader(BinaryReader reader, AssetHeader header)
        {
            try
            {
                reader.Read(header);
                Log.Info($"\n[0] 0 - {header.PackageFileSummary.TotalHeaderSize} ({header.PackageFileSummary.TotalHeaderSize}): File Header\n");
                header.SaveToJson("C:/Temp/Header.json");
            }
            catch (Exception ex)
            {
                header.PackageFileSummary.SaveToJson("C:/Temp/PackageFileSummary.json");
                Log.Info(ex.Message);
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

        private static void CheckAssetHeader(BinaryReader reader, AssetHeader obj)
        {
            #region Check Position
            if (obj.PackageFileSummary.TotalHeaderSize != reader.BaseStream.Position)
            {
                Log.Info($"Wrong StructHeader Position: {obj.PackageFileSummary.TotalHeaderSize} instead of {reader.BaseStream.Position}");
                throw new InvalidOperationException();
            }
            #endregion
            #region Check Size
            byte[] createdBytes = obj.GetBytes();
            long createdSize = createdBytes.Length;
            long originalSize = reader.BaseStream.Position;
            if (createdSize != originalSize)
            {
                Log.Info($"Wrong StructHeader Size: {originalSize} instead of {createdSize}");
                throw new InvalidOperationException();
            }
            #endregion
            #region Check Binary Content
            long currentPosition = reader.BaseStream.Position;
            byte[] originalBytes = new byte[originalSize];
            reader.BaseStream.Position = 0;
            reader.Read(originalBytes);
            if (!DataComparer.CompareBytes(originalBytes, createdBytes))
            {
                Log.Info($"Binary creation failed");
                DataComparer.DumpAssetHeaders(originalBytes, obj, createdBytes, null);
                throw new InvalidOperationException();
            }
            reader.BaseStream.Position = currentPosition;
            #endregion
            #region Check Json Content
            var obj2 = obj.ToJson().ToObject<AssetHeader>();
            byte[] createdBytes2 = obj2.GetBytes();
            if (!DataComparer.CompareBytes(createdBytes, createdBytes2))
            {
                Log.Info($"Json creation failed");
                DataComparer.DumpAssetHeaders(originalBytes, obj, createdBytes, obj2);
                throw new InvalidOperationException();
            }
            #endregion
        }

        private static void CheckAssetObject(BinaryReader reader, AssetObject obj)
        {
            ///Log.Info($"Checking AssetObject {obj.Index}");
            #region Check Position
            if (obj.NextOffset != reader.BaseStream.Position)
            {
                Log.Info($"Wrong Position: {obj.NextOffset} instead of {reader.BaseStream.Position}");
                throw new InvalidOperationException();
            }
            #endregion
            #region Check Size
            byte[] createdBytes = obj.GetBytes();
            long createdSize = createdBytes.Length;

            long originalSize = reader.BaseStream.Position - obj.Offset;
            if (createdSize != originalSize)
            {
                Log.Info($"Wrong Size: {originalSize} instead of {createdSize}");
                throw new InvalidOperationException();
            }
            #endregion
            #region Check Binary Content
            long currentPosition = reader.BaseStream.Position;
            byte[] originalBytes = new byte[originalSize];
            reader.BaseStream.Position = obj.Offset;
            reader.Read(originalBytes);
            if (!DataComparer.CompareBytes(originalBytes, createdBytes))
            {
                Log.Info($"Wrong Binary Value");
                throw new InvalidOperationException();
            }
            reader.BaseStream.Position = currentPosition;
            #endregion
            #region Check Json Content
            if (!DataComparer.CheckAssetObject(obj, createdBytes))
            {
                Log.Info($"Wrong Json Value");
                throw new InvalidOperationException();
            }
            #endregion
        }

        private static void SetupObjects(StructAsset item)
        {
            if (item.Header.ExportMap is null)
                return;
            item.Objects = item.Header.ExportMap.Select((x, i) => new AssetObject
            {
                Index = i + 1,
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
