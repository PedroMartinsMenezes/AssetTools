using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("FArchive& operator<<(FArchive& Ar, TVector2<double>& V)")]
    public class FVector2f
    {
        public float X;
        public float Y;

        public const string StructName = "Vector2D";
        public const int SIZE = 8;

        public FVector2f() { }

        public FVector2f(BinaryReader reader)
        {
            X = reader.ReadSingle();
            Y = reader.ReadSingle();
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
        }
    }

    public class FVector2fJsonConverter : JsonConverter<FVector2f>
    {
        public override FVector2f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector2f { X = v[0], Y = v[1] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector2f value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y}");
            writer.WriteStringValue(s);
        }
    }
}
