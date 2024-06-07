using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    public class FName
    {
        public const int SIZE = 8;

        public FName() { }

        public FName(string name)
        {
            if (GlobalNames.TryGetIndex(name, out var index))
            {
                ComparisonIndex.Value = index;
            }
            else if (Regex.Match(name, "(.*)_(\\d+)$") is var match && match.Success)
            {
                ComparisonIndex.Value = GlobalNames.GetIndex(match.Groups[1].Value);
                Number = 1 + uint.Parse(match.Groups[2].Value);
            }
        }

        public FNameEntryId ComparisonIndex = new();
        public UInt32 Number;

        public string Value => GlobalNames.Get(ComparisonIndex);

        public string DisplayValue => Number == 0 ? "None" : $"{Value}_{Number - 1}";

        [JsonIgnore] public bool IsFilled => GlobalNames.IsFilled(ComparisonIndex);

        public override string ToString()
        {
            if (ComparisonIndex.Value == GlobalNames.None.ComparisonIndex.Value)
                return GlobalNames.None.Value;
            else if (Number == 0)
                return Value;
            else
                return $"{Value}_{Math.Max(0, Number - 1)}";
        }
    }

    public static class FNameExt
    {
        public static FName Write(this BinaryWriter writer, FName name)
        {
            writer.Write(name.ComparisonIndex.Value);
            writer.Write(name.Number);
            return name;
        }

        public static FName Read(this BinaryReader reader, ref FName item)
        {
            var transfer = GlobalObjects.Transfer;
            item ??= new();

            item.ComparisonIndex.Move(transfer);

            if (!GlobalNames.IsValid(item.ComparisonIndex))
                throw new InvalidOperationException($"Invalid name index {item.ComparisonIndex}");

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
            if (text == GlobalNames.None.Value)
            {
                return GlobalNames.None;
            }
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
            string text = value.ToString();
            writer.WriteStringValue(text);
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FName value, JsonSerializerOptions options)
        {
            string text = value.ToString();
            writer.WritePropertyName(text);
        }
    }
}


