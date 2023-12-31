using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FName
    {
        public FNameEntryId ComparisonIndex = new();
        public UInt32 Number;

        [JsonIgnore] public string Value => string.Empty;

        public FName() { }

        public FName(UInt32 a, UInt32 b)
        {
            ComparisonIndex.Value = a;
            Number = b;
        }
    }

    public static class FNameExt
    {
        public static void Write(this BinaryWriter writer, FName name)
        {
            writer.Write(name.ComparisonIndex.Value);
            writer.Write(name.Number);
        }

        //TODO remover ref
        public static void Read(this BinaryReader reader, ref FName item)
        {
            item = new FName(reader.ReadUInt32(), reader.ReadUInt32());

            //reader.Read(item.ComparisonIndex);
            //reader.Read(ref item.Number);
        }
    }
}


