using System.Text.Json.Serialization;
using System.Text.Json;

namespace AssetTool
{
    public class FRigidBodyIndexPair : ITransferible
    {
        public Int32[] Indices = [0, 0];

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Indices[0]);
            transfer.Move(ref Indices[1]);
            return this;
        }

        public override string ToString() => $"{Indices[0]} {Indices[1]}";

        public static FRigidBodyIndexPair FromString(string text)
        {
            return new FRigidBodyIndexPair { Indices = text.Split(' ').Select(int.Parse).ToArray() };
        }
    }

    public class FRigidBodyIndexPairJsonConverter : JsonConverter<FRigidBodyIndexPair>
    {
        public override FRigidBodyIndexPair Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string text = reader.GetString()!;
            return FRigidBodyIndexPair.FromString(text);
        }
        public override FRigidBodyIndexPair ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }
        public override void Write(Utf8JsonWriter writer, FRigidBodyIndexPair value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FRigidBodyIndexPair value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.ToString());
        }
    }
}
