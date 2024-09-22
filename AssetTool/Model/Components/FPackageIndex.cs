using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Index}")]
    public class FPackageIndex
    {
        public const int SIZE = 4;

        public Int32 Index;

        public FPackageIndex() { }

        public FPackageIndex(string value)
        {
            Index = Int32.Parse(value);
        }

        public FPackageIndex Move(Transfer transfer)
        {
            transfer.Move(ref Index);
            return this;
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
        public override FPackageIndex ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FPackageIndex { Index = int.Parse(reader.GetString()) };
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FPackageIndex value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.Index.ToString());
        }
    }
}
