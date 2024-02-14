namespace AssetTool.Service
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

        public static bool CompareBytes(byte[] bytes1, byte[] bytes2, out int pos)
        {
            pos = -1;
            if (bytes1.Length != bytes2.Length)
            {
                return false;
            }
            for (int i = 0; i < bytes1.Length; i++)
            {
                if (bytes1[i] != bytes2[i])
                {
                    pos = i;
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

        public static byte[] GetBytes(this StructHeader obj)
        {
            MemoryStream stream = new();
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(obj);
            byte[] bytes = new byte[writer.BaseStream.Position];
            stream.Seek(0, SeekOrigin.Begin);
            stream.Read(bytes);
            return bytes;
        }

        public static bool CheckJson(StructHeader obj, out int pos)
        {
            pos = -1;
            byte[] bytes1 = obj.GetBytes();
            StructHeader obj2 = obj.ToJson().ToObject<StructHeader>();
            byte[] bytes2 = obj2.GetBytes();
            bool success = CompareBytes(bytes1, bytes2, out int pos2);
            if (!success)
            {
                pos = pos2;
                obj.SaveToJson($"C:/Temp/StructHeader-Before.json");
                obj2.SaveToJson($"C:/Temp/StructHeader-After.json");
            }
            return success;
        }

        public static bool CheckJson(AssetObject obj, out int pos)
        {
            pos = -1;
            byte[] bytes1 = obj.GetBytes();
            AssetObject obj2 = obj.ToJson().ToObject<AssetObject>();
            byte[] bytes2 = obj2.GetBytes();
            bool success = CompareBytes(bytes1, bytes2, out int pos2);
            if (!success)
            {
                pos = pos2;
                obj.SaveToJson($"C:/Temp/AssetObject-{obj.Index}-{obj.Type}-Before.json");
                obj2.SaveToJson($"C:/Temp/AssetObject-{obj2.Index}-{obj.Type}-After.json");
                File.WriteAllBytes($"C:/Temp/AssetObject-{obj.Index}-{obj.Type}-Before.dat", bytes1);
                File.WriteAllBytes($"C:/Temp/AssetObject-{obj.Index}-{obj.Type}-After.dat", bytes2);
            }
            return success;
        }
    }
}
