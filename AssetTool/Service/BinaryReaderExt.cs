using System.Text;

namespace AssetTool
{
    public static class BinaryReaderExt
    {
        public static void Read(this BinaryReader reader, ref Int16 item) => item = reader.ReadInt16();

        public static void Read(this BinaryReader reader, ref UInt16 item) => item = reader.ReadUInt16();

        public static void Read(this BinaryReader reader, ref Int32 item) => item = reader.ReadInt32();

        public static void Read(this BinaryReader reader, ref UInt32 item) => item = reader.ReadUInt32();

        public static void Read(this BinaryReader reader, ref Int64 item) => item = reader.ReadInt64();

        public static void Read(this BinaryReader reader, ref UInt64 item) => item = reader.ReadUInt64();

        public static void Read(this BinaryReader reader, List<int> list)
        {
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                list.Add(reader.ReadInt32());
            }
        }
    }
}
