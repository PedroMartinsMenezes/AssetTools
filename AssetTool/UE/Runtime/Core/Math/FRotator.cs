using System.Globalization;
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

        public FRotator ReadDouble(BinaryReader reader)
        {
            Pitch = reader.ReadDouble();
            Yaw = reader.ReadDouble();
            Roll = reader.ReadDouble();
            return this;
        }

        public FRotator ReadFloat(BinaryReader reader)
        {
            Pitch = reader.ReadSingle();
            Yaw = reader.ReadSingle();
            Roll = reader.ReadSingle();
            return this;
        }

        public void WriteDouble(BinaryWriter writer)
        {
            writer.Write(Pitch);
            writer.Write(Yaw);
            writer.Write(Roll);
        }

        public void WriteFloat(BinaryWriter writer)
        {
            writer.Write((float)Pitch);
            writer.Write((float)Yaw);
            writer.Write((float)Roll);
        }
    }

    public class FRotatorJsonConverter : JsonConverter<FRotator>
    {
        public override FRotator Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FRotator { Pitch = v[0], Yaw = v[1], Roll = v[2] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FRotator value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.Pitch} {value.Yaw} {value.Roll}");
            writer.WriteStringValue(s);
        }
    }
}
