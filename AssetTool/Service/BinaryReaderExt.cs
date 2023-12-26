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
    }
}
