using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class TRef : ITransferable
    {
        public Int32 ExportIndex;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ExportIndex);
            if (ExportIndex > transfer.GlobalObjects.ExportMap.Count)
            {
                throw new InvalidOperationException("Invalid Export Index");
            }
            return this;
        }

        public override string ToString() => ExportIndex.ToString();

        public static TRef FromString(string str) => new TRef { ExportIndex = Int32.Parse(str) };
    }

    public class TRefJsonConverter : JsonConverter<TRef>
    {
        public override TRef Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new TRef { ExportIndex = reader.GetInt32() };
        }
        public override TRef ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new TRef { ExportIndex = Int32.Parse(reader.GetString()) };
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
