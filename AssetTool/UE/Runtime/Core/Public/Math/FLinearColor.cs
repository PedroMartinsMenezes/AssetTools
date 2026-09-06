using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [TransferableStruct("LinearColor", "LinearColor", 16)]
    [DebuggerDisplay("({R} {G} {B} {A})")]
    public class FLinearColor : ITransferable, ITagConverter
    {
        public const string StructName = "LinearColor";
        public const int SIZE = 16;

        public float R;
        public float G;
        public float B;
        public float A;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref R);
            transfer.Move(ref G);
            transfer.Move(ref B);
            transfer.Move(ref A);
            return this;
        }
    }

    public class FLinearColorJsonConverter : JsonConverter<FLinearColor>
    {
        public override FLinearColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToFloatArray();
            var obj = new FLinearColor { R = v[0], G = v[1], B = v[2], A = v[3] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FLinearColor value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.R} {value.G} {value.B} {value.A}");
            writer.WriteStringValue(s);
        }
    }

    public class FLinearColorListJsonConverter : JsonConverter<List<FLinearColor>>
    {
        public override List<FLinearColor> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(" | ").Select(x => x.Split(' ') is var v ? new FLinearColor { R = float.Parse(v[0], CultureInfo.InvariantCulture), G = float.Parse(v[1], CultureInfo.InvariantCulture), B = float.Parse(v[2], CultureInfo.InvariantCulture), A = float.Parse(v[3], CultureInfo.InvariantCulture) } : default).ToList();
        }

        public override void Write(Utf8JsonWriter writer, List<FLinearColor> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => string.Create(CultureInfo.InvariantCulture, $"{x.R} {x.G} {x.B} {x.A}"))));
        }
    }
}
