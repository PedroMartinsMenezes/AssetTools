using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [TransferibleStruct("LinearColor", "LinearColor", 16)]
    public class FLinearColor : ITransferible, ITagConverter, ITagSelector
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
        public int TagSize(Transfer transfer) => 16;
        public object TagRead(object elem, Transfer transfer)
        {
            return elem.ToObject<FLinearColor>(transfer);
        }
        #endregion

        #region ITagSelector
        public string GetType(int size)
        {
            return "LinearColor";
        }
        public object GetValue(object value, int size)
        {
            return value;
        }
        #endregion
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
