using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    public class FName : ITransferible
    {
        public const string SEPARATOR = "\"";
        public const int SIZE = 8;
        [JsonIgnore] public Transfer transfer;

        public FName() { }

        public FName(string name, Transfer transfer)
        {
            (uint index, uint number) = FName.GetIndexAndNumber(name, transfer);
            ComparisonIndex.Value = index;
            Number = number;
            this.transfer = transfer;
            Value = transfer.GlobalNames.Get(ComparisonIndex);
        }

        public FName(uint index, uint number, Transfer transfer)
        {
            ComparisonIndex.Value = index;
            Number = number;
            this.transfer = transfer;
            Value = transfer.GlobalNames.Get(ComparisonIndex);
        }

        public FNameEntryId ComparisonIndex = new();
        public UInt32 Number;

        [JsonIgnore] public string Value { get; set; }

        public string DisplayValue => (Number == 0 && ComparisonIndex.Value == 0) ? "None" : Number == 0 ? Value : $"{Value}{SEPARATOR}{Number - 1}";

        public override string ToString()
        {
            if (Value == default || (Value == "None" && ComparisonIndex.Value == 0))
                return "None";
            else if (Number == 0)
                return Value;
            else
                return $"{Value}{SEPARATOR}{Math.Max(0, Number - 1)}";
        }

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ComparisonIndex);

            if (!transfer.GlobalNames.IsValid(ComparisonIndex))
                throw new InvalidOperationException($"Invalid name index {ComparisonIndex.Value}");

            transfer.Move(ref Number);

            Value = transfer.GlobalNames.Get(ComparisonIndex);

            transfer.UpdateNameToIndexMap(this);

            return this;
        }

        public static (uint, uint) GetIndexAndNumber(string name, Transfer transfer)
        {
            if (name.Contains(FName.SEPARATOR))
            {
                string[] parts = name.Split(FName.SEPARATOR);
                return (transfer.GlobalNames.NameToIndex[parts[0]], 1 + uint.Parse(parts[1]));
            }
            else
            {
                return (transfer.GlobalNames.NameToIndex[name], 0);
            }
        }

        public bool IsNone(Transfer transfer)
        {
            return ComparisonIndex.Value == transfer.GlobalNames.None.ComparisonIndex.Value && Number == 0;
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

        public static FName ReadFName(this Transfer transfer)
        {
            FName name = new FName
            {
                ComparisonIndex = new() { Value = transfer.reader.ReadUInt32() },
                Number = transfer.reader.ReadUInt32(),
            };
            name.Value = transfer.GlobalNames.Get(name.ComparisonIndex);
            transfer.UpdateNameToIndexMap(name);
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
            string[] parts = reader.GetString()!.Split(FName.SEPARATOR);
            uint index = transfer.GlobalNames.NameToIndex[parts[0]];
            uint number = parts.Length == 1 ? 0 : uint.Parse(parts[1]) + 1;
            var value = new FName { ComparisonIndex = new() { Value = index }, Number = number };
            value.Value = transfer.GlobalNames.IndexToName[index];
            transfer.UpdateNameToIndexMap(value);
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