using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FVector3d
    {
        public double X;
        public double Y;
        public double Z;

        public const string StructName = "Vector";
        public const int SIZE = 24;

        public FVector3d() { }

        public FVector3d(BinaryReader reader)
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

    public class FVector3dJsonConverter : JsonConverter<FVector3d>
    {
        public override FVector3d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector3d { X = v[0], Y = v[1], Z = v[2] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector3d value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z}");
            writer.WriteStringValue(s);
        }
    }
}
