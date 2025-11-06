using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Encoded}")]
    public struct FFloat16 : ITransferible
    {
        public UInt16 Encoded;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Encoded);
            return this;
        }

        public override string ToString()
        {
            return Encoded.ToString();
        }
    }

    public class FFloat16JsonConverter : JsonConverter<FFloat16>
    {
        public override FFloat16 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FFloat16 { Encoded = reader.GetUInt16() };
        }

        public override void Write(Utf8JsonWriter writer, FFloat16 value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.Encoded);
        }
    }
}
