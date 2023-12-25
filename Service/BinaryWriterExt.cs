using System.Text;

namespace AssetTool.Service
{
    public static class BinaryWriterExt
    {
        public static void WriteString(this BinaryWriter writer, string value)
        {
            if (value.Length > 0)
            {
                writer.Write(Encoding.ASCII.GetBytes(value));
                writer.Write((byte)0);
            }
        }

        public static void WriteGuid(this BinaryWriter writer, Guid value)
        {
            var bytes = value.ToByteArray();
            writer.Write(bytes[00..04]);
            writer.Write(new byte[] { bytes[06], bytes[07], bytes[04], bytes[05] });
            writer.Write(bytes[08..12].Reverse().ToArray());
            writer.Write(bytes[12..16].Reverse().ToArray());
        }
    }
}
