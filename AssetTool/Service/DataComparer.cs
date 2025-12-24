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

        public static string CompareBytes(byte[] bytes1, byte[] bytes2, long offset, int size)
        {
            if (size != bytes2.Length)
            {
                return "Size mismatch";
            }
            for (int i = 0; i < size; i++)
            {
                if (bytes1[i] != bytes2[i])
                {
                    return $"\n    Wrong byte at {offset + i}. Expected: 0x{bytes1[i]:X}. Actual: 0x{bytes2[i]:X}";
                }
            }
            return string.Empty;
        }

        public static string CompareStreams(Stream s1, Stream s2, int size)
        {
            if (!s1.CanRead || !s2.CanRead)
                throw new InvalidOperationException("Streams must be readable.");

            if (size != s2.Length)
                return "Size mismatch";

            int bufferSize = size < 4096 ? size : 4096;
            byte[] bytes1 = new byte[bufferSize];
            byte[] bytes2 = new byte[bufferSize];
            s1.Position = 0;
            s2.Position = 0;
            int offset = 0;
            while (true)
            {
                int read1 = s1.Read(bytes1, 0, bufferSize);
                int read2 = s2.Read(bytes2, 0, bufferSize);

                for (int i = 0; i < read2; i++)
                {
                    if (bytes1[i] != bytes2[i])
                        return $"\n    Wrong byte at {offset + i}. Expected: 0x{bytes1[i]:X}. Actual: 0x{bytes2[i]:X}";
                }

                if (read1 == 0 || read1 == size)
                    break;

                offset += bufferSize;
            }

            return string.Empty;
        }

        public static void DumpAssetHeaders(byte[] bytes1, AssetHeader obj1, byte[] bytes2, AssetHeader obj2, Transfer transfer)
        {
            obj1.SaveToJson($"C:/Temp/StructHeader-Before.json", transfer);
            if (obj2 is { }) obj2.SaveToJson($"C:/Temp/StructHeader-After.json", transfer);
            File.WriteAllBytes($"C:/Temp/StructHeader-Before.dat", bytes1);
            File.WriteAllBytes($"C:/Temp/StructHeader-After.dat", bytes2);
        }

        public static void DumpAssetObjects(byte[] bytes1, AssetObject obj1, byte[] bytes2, AssetObject obj2, Transfer transfer)
        {
            obj1.SaveToJson($"C:/Temp/AssetObject-{obj1.Index}-{obj1.ClassName}-Before.json", transfer);
            obj2.SaveToJson($"C:/Temp/AssetObject-{obj2.Index}-{obj2.ClassName}-After.json", transfer);
            if (obj2 is { }) File.WriteAllBytes($"C:/Temp/AssetObject-{obj1.Index}-{obj1.ClassName}-Before.dat", bytes1);
            File.WriteAllBytes($"C:/Temp/AssetObject-{obj2.Index}-{obj2.ClassName}-After.dat", bytes2);
        }

        public static bool AutoCheck<T>(this T self, Transfer transfer, string name, Stream source, long[] offsets) where T : ITransferable, new()
        {
            if (transfer.IsWriting || !AppConfig.DebugCheckMember || (offsets[1] - offsets[0]) == 0) return true;

            string msg = string.Empty;
            long currentPosition = source.Position;
            byte[] sourceBytes = new byte[offsets[1] - offsets[0]];
            using BinaryReader reader = new BinaryReader(source, Encoding.Default, true);
            reader.BaseStream.Position = offsets[0];
            reader.Read(sourceBytes);

            if (AppConfig.AutoCheckBinaryWriter)
            {
                Log.WriteFileNumber = Log.WriteFileNumber == 0 ? 0 : 1;
                using MemoryStream dest = new();
                using BinaryWriter writer = new BinaryWriter(dest);
                using TransferWriter transferWriter = new TransferWriter(writer, transfer);
                self.Move(transferWriter);

                byte[] destBytes = new byte[offsets[1] - offsets[0]];
                dest.Position = 0;
                _ = dest.Read(destBytes);

                if (msg.Length == 0 && DataComparer.CompareBytes(sourceBytes, destBytes, offsets[0], sourceBytes.Length) is string msg1 && msg1.Length > 0)
                    msg = $"    Binary Difference Found for {name}\n{msg1}";
            }

            T copy = JsonSerializerExt.ToStreamThenToObjectAsync(self).GetAwaiter().GetResult();

            Log.WriteFileNumber = Log.WriteFileNumber == 0 ? 0 : 2;
            using MemoryStream dest2 = new();
            using BinaryWriter writer2 = new BinaryWriter(dest2);
            using TransferWriter transferWriter2 = new TransferWriter(writer2, transfer, true, true);
            copy.Move(transferWriter2);

            byte[] destBytes2 = new byte[offsets[1] - offsets[0]];
            dest2.Position = 0;
            _ = dest2.Read(destBytes2);

            if (msg.Length == 0 && DataComparer.CompareBytes(sourceBytes, destBytes2, offsets[0], sourceBytes.Length) is string msg2 && msg2.Length > 0)
                msg = $"    Json Difference Found for {name}\n{msg2}";

            if (msg.Length > 0)
            {
                if (AppConfig.DebugFText)
                {
                    File.WriteAllText("C:/Temp/Before.json", self.ToJson());
                    File.WriteAllText("C:/Temp/After.json", copy.ToJson());
                    File.WriteAllText("C:/Temp/Before.raw.json", self.ToRawJson());
                    File.WriteAllText("C:/Temp/After.raw.json", copy.ToRawJson());
                    return false;
                }

                Log.Error(msg);
                Log.Error($"    Counter: {transfer.Counter}");
                throw new InvalidOperationException(msg);
            }
            if (currentPosition != offsets[1])
            {
                if (AppConfig.DebugFText)
                {
                    File.WriteAllText("C:/Temp/Before.json", self.ToJson());
                    File.WriteAllText("C:/Temp/After.json", copy.ToJson());
                    File.WriteAllText("C:/Temp/Before.raw.json", self.ToRawJson());
                    File.WriteAllText("C:/Temp/After.raw.json", copy.ToRawJson());
                    return false;
                }

                msg = $"    Wrong read size. Expected: {offsets[1]}. Actual: {currentPosition}";
                Log.Error(msg);
                throw new InvalidOperationException(msg);
            }
            source.Position = currentPosition;
            return msg.Length == 0;
        }
    }
}
