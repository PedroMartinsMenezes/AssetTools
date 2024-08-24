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
        [Location("void FLinkerLoad::LoadAllObjects(bool bForcePreload)")]
        public static bool Write(this BinaryWriter writer, StructAsset item)
        {
            List<bool> status = [];
            int i = 0;
            try
            {
                writer.Write(item.Header);

                item.Objects = item.Objects.OrderBy(x => x.Offset).ToList();
                for (i = 0; i < item.Objects.Count; i++)
                {
                    try
                    {
                        AssetObject obj = item.Objects[i];
                        Log.Info($"[{i + 1}] {obj.Offset} - {obj.NextOffset} ({obj.Size}): {obj.Type} {(!GlobalObjects.AssetMovers.ContainsKey(obj.Type) ? "(UObject)" : "")}");
                        writer.BaseStream.Position = obj.Offset;
                        GlobalObjects.Transfer.MoveAssetObject(obj.Type, obj);
                        status.Add(CheckWriterPosition(writer, obj));
                    }
                    catch
                    {
                        status.Add(false);
                    }
                }

                writer.Write(item.Footer);
                return status.TrueForAll(x => x);
            }
            catch (Exception ex)
            {
                Log.Info($"    {ex.Message}");
                return false;
            }
        }

        [Location("void FLinkerLoad::LoadAllObjects(bool bForcePreload)")]
        public static bool Read(this BinaryReader reader, StructAsset item)
        {
            List<bool> status = [];
            try
            {
                ReadHeader(reader, item.Header);
                CheckAssetHeader(reader, item.Header);
                SetupObjects(item);

                Log.WriteFileNumber = 1;

                Log.Info($"\nReading Export Objects: {item.Objects.Count}\n");
                for (int i = 0; i < item.Objects.Count; i++)
                {
                    try
                    {
                        AssetObject obj = item.Objects[i];
                        GlobalObjects.CurrentObject = obj;
                        Log.Info($"[{i + 1}] {obj.Offset} - {obj.NextOffset} ({obj.Size}): {obj.Type} {(!GlobalObjects.AssetMovers.ContainsKey(obj.Type) ? "(UObject)" : "")}");
                        reader.BaseStream.Position = obj.Offset;
                        GlobalObjects.Transfer.MoveAssetObject(obj.Type, obj);
                        status.Add(CheckReaderPosition(reader, obj));
                    }
                    catch
                    {
                        status.Add(false);
                    }
                }
                GlobalObjects.CurrentObject = null;

                reader.Read(ref item.Footer);
                return status.TrueForAll(x => x);
            }
            catch (Exception ex)
            {
                Log.Info($"    Error at {reader.BaseStream.Position}. {ex.Message}");
                return false;
            }
        }

        private static void ReadHeader(BinaryReader reader, AssetHeader header)
        {
            try
            {
                Log.Info("\nReading File Header:\n");
                reader.Read(header);
            }
            catch (Exception ex)
            {
                Log.Info(ex.Message);
            }
        }

        private static bool CheckWriterPosition(BinaryWriter writer, AssetObject obj)
        {
            if (obj.NextOffset != writer.BaseStream.Position)
            {
                Log.Info($"    Wrong Write Size. Actual({writer.BaseStream.Position}). Expected({obj.NextOffset})");
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void CheckAssetHeader(BinaryReader reader, AssetHeader obj)
        {
            if (!AppConfig.AutoCheck) return;

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
            if (!DataComparer.CompareBytes(originalBytes, createdBytes, 0))
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
            if (!DataComparer.CompareBytes(createdBytes, createdBytes2, 0))
            {
                Log.Info($"Json creation failed");
                DataComparer.DumpAssetHeaders(originalBytes, obj, createdBytes, obj2);
                throw new InvalidOperationException();
            }
            #endregion
        }

        private static bool CheckReaderPosition(BinaryReader reader, AssetObject obj)
        {
            if (!AppConfig.AutoCheck) return true;

            ///Log.Info($"Checking AssetObject {obj.Index}");
            #region Check Position
            if (obj.NextOffset != reader.BaseStream.Position)
            {
                Log.Info($"    Wrong Read Size. Actual({reader.BaseStream.Position}). Expected({obj.NextOffset})");
                return false;
            }
            #endregion
            #region Check Size            
            byte[] createdBytes = obj.GetBytes();
            long createdSize = createdBytes.Length;

            long originalSize = reader.BaseStream.Position - obj.Offset;
            if (createdSize != originalSize)
            {
                Log.Info($"    Wrong Size: {originalSize} instead of {createdSize}");
                return false;
            }
            #endregion
            #region Check Binary Content
            long currentPosition = reader.BaseStream.Position;
            byte[] originalBytes = new byte[originalSize];
            reader.BaseStream.Position = obj.Offset;
            reader.Read(originalBytes);
            if (!DataComparer.CompareBytes(originalBytes, createdBytes, obj.Offset))
            {
                Log.Info($"    Wrong Binary Value");
                return false;
            }
            reader.BaseStream.Position = currentPosition;
            #endregion
            #region Check Json Content
            if (!DataComparer.CheckAssetObject(obj, createdBytes))
            {
                Log.Info($"    Wrong Json Value");
                return false;
            }
            #endregion
            return true;
        }

        private static void SetupObjects(StructAsset item)
        {
            if (item.Header.ExportMap is null)
                return;
            item.Objects = item.Header.ExportMap.Select((x, i) => new AssetObject
            {
                Index = i + 1,
                ClassIndex = x.ClassIndex.Index,
                //Offset = x.ClassIndex.Index < 0 ? x.SerialOffset : item.Header.ExportMap[x.ClassIndex.Index - 1].SerialOffset,
                Offset = x.SerialOffset,
                Size = x.SerialSize,
                ObjectFlags = (EObjectFlags)x.ObjectFlags,
                Type = x.ClassIndex.Index < 0 ?
                    item.Header.ImportMap[-x.ClassIndex.Index - 1].ObjectName.Value :
                    item.Header.ExportMap[+x.ClassIndex.Index + 0].ObjectName.Value
            })
            .ToList();
        }
    }
}
