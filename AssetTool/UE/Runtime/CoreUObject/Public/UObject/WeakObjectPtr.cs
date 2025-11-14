using System.Text.Json.Serialization;
using System.Text.Json;

namespace AssetTool
{
    public class FWeakObjectPtr : ITransferable
    {
        public UInt32 Ptr;

        [Location("FArchive& FArchiveUObject::SerializeWeakObjectPtr(FArchive& Ar, FWeakObjectPtr& Value)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Ptr);
            return this;
        }
    }

    public class FWeakObjectPtrJsonConverter : JsonConverter<FWeakObjectPtr>
    {
        public override FWeakObjectPtr Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FWeakObjectPtr { Ptr = uint.Parse(reader.GetString()) };
        }
        public override FWeakObjectPtr ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }
        public override void Write(Utf8JsonWriter writer, FWeakObjectPtr value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.Ptr}");
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FWeakObjectPtr value, JsonSerializerOptions options)
        {
            writer.WritePropertyName($"{value.Ptr}");
        }
    }
}