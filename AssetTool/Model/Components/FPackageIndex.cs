using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FPackageIndex
    {
        public Int32 Index;
    }

    public static class FPackageIndexExt
    {
        public static void Write(this BinaryWriter writer, FPackageIndex item)
        {
            writer.Write(item.Index);
        }

        public static FPackageIndex ReadPackageIndex(this BinaryReader reader, FPackageIndex item)
        {
            reader.Read(ref item.Index);
            return item;
        }

        public static List<FPackageIndex> ReadList(this BinaryReader reader, int count, FPackageIndex item)
        {
            return Enumerable.Range(0, count).Select(x => reader.ReadPackageIndex(new FPackageIndex())).ToList();
        }
    }

    public class FPackageIndexJsonConverter : JsonConverter<FPackageIndex>
    {
        public override FPackageIndex Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FPackageIndex { Index = reader.GetInt32() };
        }

        public override void Write(Utf8JsonWriter writer, FPackageIndex value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.Index);
        }
    }
}
