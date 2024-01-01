using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FName
    {
        public FNameEntryId ComparisonIndex = new();
        public UInt32 Number;
    }

    public static class FNameExt
    {
        public static void Write(this BinaryWriter writer, FName name)
        {
            writer.Write(name.ComparisonIndex.Value);
            writer.Write(name.Number);
        }

        public static void Write(this BinaryWriter writer, List<FName> list)
        {
            writer.Write(list.Count);
            list.ForEach(writer.Write);
        }

        public static FName Read(this BinaryReader reader, FName item)
        {
            reader.Read(item.ComparisonIndex);
            reader.Read(ref item.Number);
            return item;
        }
    }
}


