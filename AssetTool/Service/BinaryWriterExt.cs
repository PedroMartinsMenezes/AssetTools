using AssetTool.Model.Basic;
using System.Text;

namespace AssetTool.Service
{
    public static class BinaryWriterExt
    {
        public static void Write(this BinaryWriter writer, FString text)
        {
            writer.Write(text.Length);
            if (text.Length > 0)
            {
                writer.Write(text.ToByteArray());
                writer.Write((byte)0);
            }
        }

        public static void Write(this BinaryWriter writer, FGuid guid)
        {
            var bytes = guid.ToByteArray();
            writer.Write(bytes);
        }

        public static void Write(this BinaryWriter writer, FName name)
        {
            writer.Write(name.ComparisonIndex.Value);
            writer.Write(name.Number);
            writer.Write(name.DisplayIndex.Value);
        }

        public static void WriteIncomplete(this BinaryWriter writer, FName name)
        {
            writer.Write(name.ComparisonIndex.Value);
            writer.Write(name.Number);
        }
    }
}
