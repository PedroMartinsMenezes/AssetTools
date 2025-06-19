using System.Text.Json.Serialization;
using System.Text.Json;

namespace AssetTool
{
    public class TTuple<T1, T2> : ITransferible where T1 : ITransferible where T2 : ITransferible
    {
        public T1 Item1;
        public T2 Item2;

        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref Item1);
            transfer.Move(ref Item2);
            return this;
        }
    }

    public class TTupleFNameFNameJsonConverter : JsonConverter<TTuple<FName, FName>>
    {
        public Transfer transfer;

        public TTupleFNameFNameJsonConverter SetTransfer(Transfer transfer)
        {
            this.transfer = transfer;
            return this;
        }

        public override TTuple<FName, FName> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string[] parts = reader.GetString().Split(' ');
            return new TTuple<FName, FName> { Item1 = new FName(parts[0], transfer), Item2 = new FName(parts[1], transfer) };
        }

        public override TTuple<FName, FName> ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }

        public override void Write(Utf8JsonWriter writer, TTuple<FName, FName> value, JsonSerializerOptions options)
        {
            string key = $"{value.Item1.ToString()} {value.Item2.ToString()}";
            writer.WriteStringValue(key);
        }

        public override void WriteAsPropertyName(Utf8JsonWriter writer, TTuple<FName, FName> value, JsonSerializerOptions options)
        {
            string key = $"{value.Item1.ToString()} {value.Item2.ToString()}";
            writer.WritePropertyName(key);
        }
    }
}
