using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FPackageIndex
    {
        public Int32 Index;

        public FPackageIndex() { }

        public FPackageIndex(string value)
        {
            Index = Int32.Parse(value);
        }

        public override string ToString()
        {
            return Index.ToString();
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
