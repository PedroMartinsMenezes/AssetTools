using System.Text;

namespace AssetTool
{
    public static class DataComparer
    {
        public static bool CompareFiles(string file1, string file2)
        {
            int file1byte;
            int file2byte;
            FileStream fs1;
            FileStream fs2;
            if (file1 == file2)
            {
                return true;
            }
            fs1 = new FileStream(file1, FileMode.Open);
            fs2 = new FileStream(file2, FileMode.Open);
            if (fs1.Length != fs2.Length)
            {
                fs1.Close();
                fs2.Close();
                return false;
            }
            do
            {
                file1byte = fs1.ReadByte();
                file2byte = fs2.ReadByte();
            }
            while ((file1byte == file2byte) && (file1byte != -1));
            fs1.Close();
            fs2.Close();
            return ((file1byte - file2byte) == 0);
        }

        public static bool CompareBytes(byte[] bytes1, byte[] bytes2, long offset)
        {
            if (bytes1.Length != bytes2.Length)
            {
                return false;
            }
            for (int i = 0; i < bytes1.Length; i++)
            {
                if (bytes1[i] != bytes2[i])
                {
                    Log.Error($"\n    Wrong byte at {offset + i}. Expected: 0x{bytes1[i]:X}. Actual: 0x{bytes2[i]:X}");
                    return false;
                }
            }
            return true;
        }

        public static byte[] GetBytes(this AssetHeader obj)
        {
            var currentTransfer = GlobalObjects.Transfer;

            MemoryStream stream = new();
            BinaryWriter writer = new BinaryWriter(stream);
            GlobalObjects.Transfer = new TransferWriter(writer);
            obj.Move(GlobalObjects.Transfer);
            byte[] bytes = new byte[writer.BaseStream.Position];
            stream.Seek(0, SeekOrigin.Begin);
            _ = stream.Read(bytes);

            GlobalObjects.Transfer = currentTransfer;
            return bytes;
        }

        public static void DumpAssetHeaders(byte[] bytes1, AssetHeader obj1, byte[] bytes2, AssetHeader obj2)
        {
            obj1.SaveToJson($"C:/Temp/StructHeader-Before.json");
            if (obj2 is { }) obj2.SaveToJson($"C:/Temp/StructHeader-After.json");
            File.WriteAllBytes($"C:/Temp/StructHeader-Before.dat", bytes1);
            File.WriteAllBytes($"C:/Temp/StructHeader-After.dat", bytes2);
        }

        public static void DumpAssetObjects(byte[] bytes1, AssetObject obj1, byte[] bytes2, AssetObject obj2)
        {
            obj1.SaveToJson($"C:/Temp/AssetObject-{obj1.Index}-{obj1.Type}-Before.json");
            obj2.SaveToJson($"C:/Temp/AssetObject-{obj2.Index}-{obj2.Type}-After.json");
            if (obj2 is { }) File.WriteAllBytes($"C:/Temp/AssetObject-{obj1.Index}-{obj1.Type}-Before.dat", bytes1);
            File.WriteAllBytes($"C:/Temp/AssetObject-{obj2.Index}-{obj2.Type}-After.dat", bytes2);
        }


        public static bool AutoCheck<T>(this T self, string name, Stream source, long[] offsets, Action<BinaryWriter> writerFunc) where T : new() //@@@ remove
        {
            Transfer currentTransfer = GlobalObjects.Transfer;
            try
            {
                if (!AppConfig.AutoCheck || (offsets[1] - offsets[0]) == 0) return true;

                long currentPosition = source.Position;
                byte[] sourceBytes = new byte[offsets[1] - offsets[0]];
                using BinaryReader reader = new BinaryReader(source, Encoding.Default, true);
                reader.BaseStream.Position = offsets[0];
                reader.Read(sourceBytes);

                using MemoryStream dest = new();
                using BinaryWriter writer = new BinaryWriter(dest);

                Log.WriteFileNumber = Log.WriteFileNumber == 0 ? 0 : 1;
                GlobalObjects.Transfer = AppConfig.DebugAutoCheck ? new DebugTransferWriter(writer) : new TransferWriter(writer);
                writerFunc(writer);

                byte[] destBytes = new byte[offsets[1] - offsets[0]];
                dest.Position = 0;
                _ = dest.Read(destBytes);

                var self2 = self.ToJson().ToObject<T>();
                using MemoryStream dest2 = new();
                using BinaryWriter writer2 = new BinaryWriter(dest2);

                Log.WriteFileNumber = Log.WriteFileNumber == 0 ? 0 : 2;
                GlobalObjects.Transfer = AppConfig.DebugAutoCheck ? new DebugTransferWriter2(writer2) : new TransferWriter(writer2);
                writerFunc(writer2);

                byte[] destBytes2 = new byte[offsets[1] - offsets[0]];
                dest2.Position = 0;
                _ = dest2.Read(destBytes2);

                string msg = string.Empty;
                if (!CompareBytes(sourceBytes, destBytes, offsets[0]))
                    msg = $"    Binary Difference Found for {name}";

                if (msg.Length == 0 && !CompareBytes(destBytes, destBytes2, offsets[0]))
                    msg = $"    Json Difference Found for {name}";

                if (msg.Length > 0)
                {
                    Log.Error(msg);
                    self.SaveToJson($"C:/Temp/{name}-Source.json");
                    self2.SaveToJson($"C:/Temp/{name}-Dest.json");
                    File.WriteAllBytes($"C:/Temp/{name}-Source.dat", sourceBytes);
                    File.WriteAllBytes($"C:/Temp/{name}-Dest.dat", destBytes);

                    Log.Error($"    Counter: {currentTransfer.Counter}");
                    throw new InvalidOperationException(msg);
                }
                if (currentPosition != offsets[1])
                {
                    msg = $"    Wrong read size. Expected: {offsets[1]}. Actual: {currentPosition}";
                    Log.Error(msg);
                    throw new InvalidOperationException(msg);
                }
                GlobalObjects.Transfer = currentTransfer;
                source.Position = currentPosition;
                return msg.Length == 0;
            }
            catch
            {
                GlobalObjects.Transfer = currentTransfer;
                throw;
            }
        }
    }
}
