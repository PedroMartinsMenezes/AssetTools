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

        public static bool CompareBytes(byte[] bytes1, byte[] bytes2)
        {
            if (bytes1.Length != bytes2.Length)
            {
                return false;
            }
            for (int i = 0; i < bytes1.Length; i++)
            {
                if (bytes1[i] != bytes2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static byte[] GetBytes(this AssetObject obj)
        {
            MemoryStream stream = new();
            BinaryWriter writer = new BinaryWriter(stream);
            writer.WriteAssetObject(obj.Type, obj);
            byte[] bytes = new byte[writer.BaseStream.Position];
            stream.Seek(0, SeekOrigin.Begin);
            stream.Read(bytes);
            return bytes;
        }

        public static byte[] GetBytes(this AssetHeader obj)
        {
            MemoryStream stream = new();
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(obj);
            byte[] bytes = new byte[writer.BaseStream.Position];
            stream.Seek(0, SeekOrigin.Begin);
            stream.Read(bytes);
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

        public static bool CheckAssetObject(AssetObject obj, byte[] bytes1)
        {
            AssetObject obj2 = obj.ToJson().ToObject<AssetObject>();
            byte[] bytes2 = obj2.GetBytes();
            bool success = CompareBytes(bytes1, bytes2);
            if (!success)
            {
                DumpAssetObjects(bytes1, obj, bytes2, obj2);
            }
            return success;
        }

        public static bool AutoCheck<T>(this T self, string name, Stream source, long[] offsets) where T : new()
        {
            long currentPosition = source.Position;
            byte[] sourceBytes = new byte[offsets[1] - offsets[0]];
            using BinaryReader reader = new BinaryReader(source, Encoding.Default, true);
            reader.BaseStream.Position = offsets[0];
            reader.Read(sourceBytes);

            using MemoryStream dest = new();
            using BinaryWriter writer = new BinaryWriter(dest);
            writer.WriteValue(ref self, null);
            byte[] destBytes = new byte[writer.BaseStream.Position];
            dest.Position = 0;
            dest.Read(destBytes);

            var self2 = self.ToJson().ToObject<T>();
            using MemoryStream dest2 = new();
            using BinaryWriter writer2 = new BinaryWriter(dest2);
            writer2.WriteValue(ref self2, null);
            byte[] destBytes2 = new byte[writer2.BaseStream.Position];
            dest2.Position = 0;
            dest2.Read(destBytes2);

            string msg = string.Empty;
            if (!CompareBytes(sourceBytes, destBytes))
                msg = $"Binary Difference Found for {name}";

            if (msg.Length == 0 && !CompareBytes(destBytes, destBytes2))
                msg = $"Json Difference Found for {name}";

            if (msg.Length > 0)
            {
                Log.Info(msg);
                self.SaveToJson($"C:/Temp/{name}-Source.json");
                self2.SaveToJson($"C:/Temp/{name}-Dest.json");
                File.WriteAllBytes($"C:/Temp/{name}-Source.dat", sourceBytes);
                File.WriteAllBytes($"C:/Temp/{name}-Dest.dat", destBytes);

                throw new Exception(msg);
            }

            source.Position = currentPosition;
            return msg.Length == 0;
        }
    }
}
