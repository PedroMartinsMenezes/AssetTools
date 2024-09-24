using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [TransferibleStruct("Color")]
    public class FColor : ITransferible
    {
        public const string StructName = "Color";

        public byte R;
        public byte G;
        public byte B;
        public byte A;

        public ITransferible Move(Transfer transfer)
        {
            ///PLATFORM_LITTLE_ENDIAN
            transfer.Move(ref B);
            transfer.Move(ref G);
            transfer.Move(ref R);
            transfer.Move(ref A);
            return this;
        }
    }

    public class FColorJsonConverter : JsonConverter<FColor>
    {
        public override FColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => byte.Parse(x)).ToArray();
            var obj = new FColor { B = v[0], G = v[1], R = v[2], A = v[3] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FColor value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.B} {value.G} {value.R} {value.A}");
            writer.WriteStringValue(s);
        }
    }
}
