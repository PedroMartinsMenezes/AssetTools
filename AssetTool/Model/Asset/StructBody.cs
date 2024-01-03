using AssetTool.Model.Components;

namespace AssetTool
{
    public class StructBody
    {
        public int Offset;
        public FPropertyTag PropertyTag = new();
    }

    public static class StructBodyExt
    {
        public static void Write(this BinaryWriter writer, StructBody item)
        {
            writer.BaseStream.Position = item.Offset;
            writer.Write(item.PropertyTag);
        }

        public static StructBody Read(this BinaryReader reader, StructBody item)
        {
            reader.BaseStream.Position = item.Offset;
            reader.Read(item.PropertyTag);
            return item;
        }
    }
}
