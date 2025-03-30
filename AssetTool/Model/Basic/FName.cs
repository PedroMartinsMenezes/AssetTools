using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    public class FName : ITransferible
    {
        public const int SIZE = 8;
        [JsonIgnore] public Transfer transfer;

        public FName() { }

        public FName(string name, Transfer transfer)
        {
            (uint index, uint number) = transfer.GlobalNames.GetIndexAndNumber(name);
            ComparisonIndex.Value = index;
            Number = number;
            this.transfer = transfer;

            Value = transfer.GlobalNames.Get(ComparisonIndex);
        }

        public FNameEntryId ComparisonIndex = new();
        public UInt32 Number;

        ///public string Value => transfer.GlobalNames.Get(ComparisonIndex);
        [JsonIgnore] public string Value { get; set; }

        public string DisplayValue => Number == 0 ? "None" : $"{Value}_{Number - 1}";

        ///[JsonIgnore] public bool IsFilled => transfer.GlobalNames.IsFilled(ComparisonIndex);
        [JsonIgnore] public bool IsFilled => Value is { } && Value != "None";

        public override string ToString()
        {
            ///if (ComparisonIndex.Value == transfer.GlobalNames.None.ComparisonIndex.Value && Number == 0)
            ///return transfer.GlobalNames.None.Value;
            if (Value is null || Value == "None")
                return "None";
            else if (Number == 0)
                return Value;
            else
                return $"{Value}_{Math.Max(0, Number - 1)}";
        }

        public ITransferible Move(Transfer transfer)
        {
            ComparisonIndex.Move(transfer);

            if (!transfer.GlobalNames.IsValid(ComparisonIndex))
                throw new InvalidOperationException($"Invalid name index {ComparisonIndex.Value}");

            transfer.Move(ref Number);

            Value = transfer.GlobalNames.Get(ComparisonIndex);
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

        ///public static FName Read(this BinaryReader reader, ref FName item)
        ///{
        ///    var transfer = item.transfer;
        ///    item ??= new();
        ///    item.ComparisonIndex.Move(transfer);
        ///    if (!transfer.GlobalNames.IsValid(item.ComparisonIndex))
        ///        throw new InvalidOperationException($"Invalid name index {item.ComparisonIndex}");
        ///    reader.Read(ref item.Number);
        ///    return item;
        ///}

        public static FName ReadFName(this Transfer transfer)
        {
            FName name = new FName
            {
                ComparisonIndex = new() { Value = transfer.reader.ReadUInt32() },
                Number = transfer.reader.ReadUInt32(),
            };
            name.Value = transfer.GlobalNames.Get(name.ComparisonIndex);
            return name;
        }
    }

    public class FNameJsonConverter : JsonConverter<FName>
    {
        public Transfer transfer;

        public FNameJsonConverter SetTransfer(Transfer transfer)
        {
            this.transfer = transfer;
            return this;
        }

        public override FName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string name = reader.GetString()!;
            (uint index, uint number) = transfer.GlobalNames.GetIndexAndNumber(name);
            var value = new FName { ComparisonIndex = new() { Value = index }, Number = number };
            value.Value = transfer.GlobalNames.Get(value.ComparisonIndex);
            return value;
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