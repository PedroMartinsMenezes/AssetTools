using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FVector3f
    {
        public float X;
        public float Y;
        public float Z;

        public const string StructName = "Vector";
        public const int SIZE = 12;

        public FVector3f() { }

        public FVector3f(BinaryReader reader)
        {
            X = reader.ReadSingle();
            Y = reader.ReadSingle();
            Z = reader.ReadSingle();
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
            writer.Write(Z);
        }
    }

    public class FVector3fJsonConverter : JsonConverter<FVector3f>
    {
        public override FVector3f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector3f { X = v[0], Y = v[1], Z = v[2] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector3f value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z}");
            writer.WriteStringValue(s);
        }
    }
}
