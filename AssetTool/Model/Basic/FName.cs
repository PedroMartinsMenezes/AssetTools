using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    public class FName
    {
        public FNameEntryId ComparisonIndex = new();
        public UInt32 Number;

        public string Value => GlobalNames.Get(ComparisonIndex.Value);
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

    public class FNameJsonConverter : JsonConverter<FName>
    {
        public override FName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var x = reader.GetString()!.Split(',');
            return new FName { ComparisonIndex = new() { Value = uint.Parse(x[1]) }, Number = uint.Parse(x[2]) };
        }
        public override FName ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }
        public override void Write(Utf8JsonWriter writer, FName value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.Value}, {value.ComparisonIndex.Value}, {value.Number}");
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FName value, JsonSerializerOptions options)
        {
            writer.WritePropertyName($"{value.Value}, {value.ComparisonIndex.Value}, {value.Number}");
        }
    }
}


