using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    public class TRef
    {
        public UInt32 ExportIndex;

        public string Value => GlobalObjects.ExportDiaplayValue(ExportIndex - 1);
    }

    public static class TRefExt
    {
        public static void Write(this BinaryWriter writer, TRef item)
        {
            writer.Write(item.ExportIndex);
        }

        public static TRef Read(this BinaryReader reader, ref TRef item)
        {
            item ??= new();
            reader.Read(ref item.ExportIndex);//4+4
            return item;
        }
    }
}
