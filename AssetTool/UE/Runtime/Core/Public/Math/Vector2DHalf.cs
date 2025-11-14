using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public struct FVector2DHalf : ITransferable
    {
        public FFloat16 X;
        public FFloat16 Y;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }

        public override string ToString() => $"{X} {Y}";
    }

    public class FVector2DHalfJsonConverter : JsonConverter<FVector2DHalf>
    {
        public override FVector2DHalf Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ');
            return new FVector2DHalf { X = new FFloat16 { Encoded = ushort.Parse(v[0]) }, Y = new FFloat16 { Encoded = ushort.Parse(v[1]) } };
        }

        public override void Write(Utf8JsonWriter writer, FVector2DHalf value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.X} {value.Y}");
        }
    }

    public class FVector2DHalfArrayJsonConverter : JsonConverter<FVector2DHalf[]>
    {
        public override FVector2DHalf[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(" | ").Select(x => x.Split(' ') is var v ? new FVector2DHalf { X = new() { Encoded = UInt16.Parse(v[0]) }, Y = new() { Encoded = UInt16.Parse(v[1]) } } : default).ToArray() : [];
        }

        public override void Write(Utf8JsonWriter writer, FVector2DHalf[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value));
        }
    }
}
