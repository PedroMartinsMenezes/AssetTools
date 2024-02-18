using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("operator<<(FArchive& Ar, TRotator<double>& R)")]
    public class FRotator
    {
        public double Pitch;
        public double Yaw;
        public double Roll;

        public const string StructName = "Rotator";

        public FRotator() { }

        public FRotator(BinaryReader reader)
        {
            Pitch = reader.ReadDouble();
            Yaw = reader.ReadDouble();
            Roll = reader.ReadDouble();
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(Pitch);
            writer.Write(Yaw);
            writer.Write(Roll);
        }
    }

    public class FRotatorJsonConverter : JsonConverter<FRotator>
    {
        public override FRotator Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x)).ToArray();
            var obj = new FRotator { Pitch = v[0], Yaw = v[1], Roll = v[2] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FRotator value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{value.Pitch} {value.Yaw} {value.Roll}");
        }
    }
}
