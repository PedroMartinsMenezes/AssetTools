using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("ElementSize({ElementSize}) ElementCount({ElementCount})")]
    public class TBulkList<T> : ITransferible where T : ITransferible, new()
    {
        [JsonIgnore] public int Count => Items.Length;
        public int ElementSize;
        public int ElementCount;
        public T[] Items;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref ElementSize);

            if (ElementSize <= 0)
                throw new InvalidOperationException();

            transfer.Move(ref ElementCount);
            transfer.Move(ref Items, ElementCount);
            return this;
        }

        public ITransferible Move(Transfer transfer, bool bForcePerElementSerialization)
        {
            if (bForcePerElementSerialization)
            {
                transfer.Move(ref Items);
                return this;
            }
            else
            {
                return Move(transfer);
            }
        }
    }

    public class TBulkListTUInt16JsonConverter : JsonConverter<TBulkList<TUInt16>>
    {
        public override TBulkList<TUInt16> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var parts = reader.GetString().Split(" | ");
            var header = parts[0].Split(' ');
            int elementSize = int.Parse(header[1]);
            int elementCount = int.Parse(header[3]);
            var items = parts[1].Split(' ').Select(x => new TUInt16 { Value = UInt16.Parse(x) }).ToArray();
            return new TBulkList<TUInt16> { ElementSize = elementSize, ElementCount = elementCount, Items = items };
        }
        public override void Write(Utf8JsonWriter writer, TBulkList<TUInt16> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"ElementSize {value.ElementSize} ElementCount {value.ElementCount} | {string.Join(' ', value.Items.Select(x => x.Value))}");
        }
    }
}
