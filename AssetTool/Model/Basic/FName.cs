using AssetTool.Model.Const;
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

        public string Value => GlobalNames.Get(ComparisonIndex);

        [JsonIgnore]
        public string ValueAndNumber
        {
            get
            {
                string name = Value;
                string number = Number > 0 ? $".{Number}" : string.Empty;
                return $"{name}{number}";
            }
        }

        [JsonIgnore] public bool IsFilled => Value != Consts.None;
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
            item ??= new();
            reader.Read(item.ComparisonIndex);
            reader.Read(ref item.Number);
            return item;
        }
    }

    public class FNameJsonConverter : JsonConverter<FName>
    {
        public override FName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string[] pair = reader.GetString()!.Split('.');
            string name = pair[0];
            uint number = pair.Length > 1 ? uint.Parse(pair[1]) : 0;
            return new FName { ComparisonIndex = new() { Value = GlobalNames.GetIndex(name) }, Number = number };
        }
        public override FName ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }
        public override void Write(Utf8JsonWriter writer, FName value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ValueAndNumber);
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FName value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.ValueAndNumber);
        }
    }
}


