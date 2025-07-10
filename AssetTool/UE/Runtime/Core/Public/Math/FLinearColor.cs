using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [TransferibleStruct("LinearColor", "LinearColor", 16)]
    [DebuggerDisplay("({R} {G} {B} {A})")]
    public class FLinearColor : ITransferible, ITagConverter
    {
        public const string StructName = "LinearColor";
        public const int SIZE = 16;

        public float R;
        public float G;
        public float B;
        public float A;

        #region ITransferible
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref R);
            transfer.Move(ref G);
            transfer.Move(ref B);
            transfer.Move(ref A);
            return this;
        }
        #endregion

        #region ITagConverter
        public object DerivedToTag(object elem, Transfer transfer)
        {
            return elem.ToObject<FLinearColor>(transfer);
        }
        #endregion
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
}
