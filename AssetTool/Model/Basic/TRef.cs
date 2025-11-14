using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class TRef : ITransferable
    {
        public UInt32 ExportIndex;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ExportIndex);
            if (ExportIndex > transfer.GlobalObjects.ExportMap.Count)
            {
                throw new InvalidOperationException("Invalid Export Index");
            }
            return this;
        }
    }

    public class TRefJsonConverter : JsonConverter<TRef>
    {
        public override TRef Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var obj = new TRef { ExportIndex = reader.GetUInt32() };
            return obj;
        }
        public override TRef ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new TRef { ExportIndex = UInt32.Parse(reader.GetString()) };
        }
        public override void Write(Utf8JsonWriter writer, TRef value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.ExportIndex);
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, TRef value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.ExportIndex.ToString());
        }
    }
}
