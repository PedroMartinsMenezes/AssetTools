using System.Text.Json.Serialization;
using System.Text.Json;

namespace AssetTool
{
    public class FWeakObjectPtr
    {
        public Int32 ObjectIndex;
        public Int32 ObjectSerialNumber;

        public FWeakObjectPtr Move(Transfer transfer)
        {
            transfer.Move(ref ObjectIndex);
            transfer.Move(ref ObjectSerialNumber);
            return this;
        }
    }

    public class FWeakObjectPtrJsonConverter : JsonConverter<FWeakObjectPtr>
    {
        public override FWeakObjectPtr Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var x = reader.GetString()!.Split(',');
            return new FWeakObjectPtr { ObjectIndex = int.Parse(x[0]), ObjectSerialNumber = int.Parse(x[1]) };
        }
        public override FWeakObjectPtr ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }
        public override void Write(Utf8JsonWriter writer, FWeakObjectPtr value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.ObjectIndex}, {value.ObjectSerialNumber}");
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FWeakObjectPtr value, JsonSerializerOptions options)
        {
            writer.WritePropertyName($"{value.ObjectIndex}, {value.ObjectSerialNumber}");
        }
    }
}
