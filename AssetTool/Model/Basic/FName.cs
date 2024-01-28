using AssetTool.Model.Const;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    public class FName
    {
        public FName() { }

        public FName(string name)
        {
            if (Regex.Match(name, "(.*)_(\\d+)$") is var match && match.Success)
            {
                ComparisonIndex.Value = GlobalNames.GetIndex(match.Groups[1].Value);
                Number = 1 + uint.Parse(match.Groups[2].Value);
            }
            else
            {
                ComparisonIndex.Value = GlobalNames.GetIndex(name);
            }
        }

        public FNameEntryId ComparisonIndex = new();
        public UInt32 Number;

        public string Value => GlobalNames.Get(ComparisonIndex);

        [JsonIgnore] public bool IsFilled => GlobalNames.IsFilled(ComparisonIndex);

        public override string ToString()
        {
            return Number == 0 ? Value : $"{Value}_{Number - 1}";
        }
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

        public static FName ReadFName(this BinaryReader reader)
        {
            return new FName
            {
                ComparisonIndex = new() { Value = reader.ReadUInt32() },
                Number = reader.ReadUInt32(),
            };
        }
    }

    public class FNameJsonConverter : JsonConverter<FName>
    {
        public override FName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string text = reader.GetString()!;
            string[] pair = text.Split('_');

            if (uint.TryParse(pair[pair.Length - 1], out uint number))
            {
                string name = string.Join("_", pair.Take(pair.Length - 1));
                return new FName { ComparisonIndex = new() { Value = GlobalNames.GetIndex(name) }, Number = number + 1 };
            }
            else
            {
                string name = string.Join("_", pair.Take(pair.Length));
                return new FName { ComparisonIndex = new() { Value = GlobalNames.GetIndex(name) }, Number = 0 };
            }
        }
        public override FName ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }
        public override void Write(Utf8JsonWriter writer, FName value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FName value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.ToString());
        }
    }
}


