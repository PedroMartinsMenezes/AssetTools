using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FVector
    {
        public double X;
        public double Y;
        public double Z;

        public const string StructName = "Vector";

        public FVector() { }

        public FVector(BinaryReader reader)
        {
            X = reader.ReadDouble();
            Y = reader.ReadDouble();
            Z = reader.ReadDouble();
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
            writer.Write(Z);
        }
    }

    public class FVectorJsonConverter : JsonConverter<FVector>
    {
        public override FVector Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x)).ToArray();
            var obj = new FVector { X = v[0], Y = v[1], Z = v[2] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.X} {value.Y} {value.Z}");
        }
    }
}
