using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FLazyObjectPtr : ITransferable
    {
        public UInt32 Ptr;

        [Location("FArchive& FArchiveUObject::SerializeLazyObjectPtr(FArchive& Ar, FLazyObjectPtr& Value)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Ptr);
            return this;
        }
    }

    public class FLazyObjectPtrJsonConverter : JsonConverter<FLazyObjectPtr>
    {
        public override FLazyObjectPtr Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FLazyObjectPtr { Ptr = uint.Parse(reader.GetString()) };
        }
        public override FLazyObjectPtr ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }
        public override void Write(Utf8JsonWriter writer, FLazyObjectPtr value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.Ptr}");
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FLazyObjectPtr value, JsonSerializerOptions options)
        {
            writer.WritePropertyName($"{value.Ptr}");
        }
    }
}
