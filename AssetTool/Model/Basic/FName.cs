using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    public class FName : ITransferible
    {
        public const int SIZE = 8;

        public FName() { }

        public FName(string name)
        {
            (uint index, uint number) = GlobalNames.GetIndexAndNumber(name);
            ComparisonIndex.Value = index;
            Number = number;
        }

        public FNameEntryId ComparisonIndex = new();
        public UInt32 Number;

        public string Value => GlobalNames.Get(ComparisonIndex);

        public string DisplayValue => Number == 0 ? "None" : $"{Value}_{Number - 1}";

        [JsonIgnore] public bool IsFilled => GlobalNames.IsFilled(ComparisonIndex);

        public override string ToString()
        {
            if (ComparisonIndex.Value == GlobalNames.None.ComparisonIndex.Value && Number == 0)
                return GlobalNames.None.Value;
            else if (Number == 0)
                return Value;
            else
                return $"{Value}_{Math.Max(0, Number - 1)}";
        }

        public ITransferible Move(Transfer transfer)
        {
            ComparisonIndex.Move(transfer);

            if (!GlobalNames.IsValid(ComparisonIndex))
                throw new InvalidOperationException($"Invalid name index {ComparisonIndex.Value}");

            transfer.Move(ref Number);
            return this;
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
            string name = reader.GetString()!;
            (uint index, uint number) = GlobalNames.GetIndexAndNumber(name);
            return new FName { ComparisonIndex = new() { Value = index }, Number = number };
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