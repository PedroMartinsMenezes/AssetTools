using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [TransferableStruct("FrameNumber")]
    [DebuggerDisplay("{Value}")]
    public class FFrameNumber : ITransferable, ITransferableRaw
    {
        public static readonly int Size = 4;

        public Int32 Value;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }

        public ITransferable MoveRaw(Transfer transfer)
        {
            return Move(transfer);
        }
    }

    public class FFrameNumberJsonConverter : JsonConverter<FFrameNumber>
    {
        public override FFrameNumber Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FFrameNumber { Value = reader.GetInt32() };
        }
        public override FFrameNumber ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FFrameNumber { Value = Int32.Parse(reader.GetString()) };
        }
        public override void Write(Utf8JsonWriter writer, FFrameNumber value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.Value);
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FFrameNumber value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.Value.ToString());
        }
    }

    public class ListFFrameNumberJsonConverter : JsonConverter<List<FFrameNumber>>
    {
        public override List<FFrameNumber> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(' ').Select(x => new FFrameNumber { Value = Int32.Parse(x) }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<FFrameNumber> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
}
