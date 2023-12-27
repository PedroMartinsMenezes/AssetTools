using AssetTool.Model;
using AssetTool.Model.Basic;
using System.Text;

namespace AssetTool.Service
{
    public static class BinaryReaderExt
    {
        public static string ReadFString(this BinaryReader reader)
        {
            int size = reader.ReadInt32();
            if (size > 0)
            {
                byte[] bytes = new byte[size - 1];
                reader.Read(bytes, 0, size - 1);
                string text = Encoding.ASCII.GetString(bytes);
                _ = reader.ReadByte();
                return text;
            }
            else
            {
                return null;
            }
        }

        public static void Read(this BinaryReader reader, ref FString item)
        {
            int size = reader.ReadInt32();
            if (size > 0)
            {
                byte[] bytes = new byte[size - 1];
                reader.Read(bytes, 0, size - 1);
                string text = Encoding.ASCII.GetString(bytes);
                _ = reader.ReadByte();
                item = new FString(text);
            }
        }

        public static void Read(this BinaryReader reader, ref FName item)
        {
            item = new FName(reader.ReadUInt32(), reader.ReadUInt32(), reader.ReadUInt32());
        }

        public static void Read(this BinaryReader reader, ref FPackageIndex item)
        {
            item = new FPackageIndex { Index = reader.ReadInt32() };
        }

        public static void Read(this BinaryReader reader, ref bool item) => item = reader.ReadInt32() == 1;

        public static void Read(this BinaryReader reader, ref Int16 item) => item = reader.ReadInt16();

        public static void Read(this BinaryReader reader, ref UInt16 item) => item = reader.ReadUInt16();

        public static void Read(this BinaryReader reader, ref Int32 item) => item = reader.ReadInt32();

        public static void Read(this BinaryReader reader, ref UInt32 item) => item = reader.ReadUInt32();

        public static void Read(this BinaryReader reader, ref Int64 item) => item = reader.ReadInt64();

        public static void Read(this BinaryReader reader, ref UInt64 item) => item = reader.ReadUInt64();
    }
}
