using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FLinearColor
    {
        public float R;
        public float G;
        public float B;
        public float A;

        public const string StructName = "LinearColor";

        public FLinearColor() { }

        public FLinearColor(BinaryReader reader)
        {
            R = reader.ReadSingle();
            G = reader.ReadSingle();
            B = reader.ReadSingle();
            A = reader.ReadSingle();
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(R);
            writer.Write(G);
            writer.Write(B);
            writer.Write(A);
        }
    }

    public class FLinearColorJsonConverter : JsonConverter<FLinearColor>
    {
        public override FLinearColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FLinearColor { R = v[0], G = v[1], B = v[2], A = v[3] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FLinearColor value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.R} {value.G} {value.B} {value.A}");
            writer.WriteStringValue(s);
        }
    }
}
