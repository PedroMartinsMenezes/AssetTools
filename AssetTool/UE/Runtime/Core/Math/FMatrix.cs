using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace AssetTool
{
    public class FMatrix : ITransferible
    {
        public FPlane XPlane = new();
        public FPlane YPlane = new();
        public FPlane ZPlane = new();
        public FPlane WPlane = new();

        public ITransferible Move(Transfer transfer)
        {
            XPlane.Move(transfer);
            YPlane.Move(transfer);
            ZPlane.Move(transfer);
            WPlane.Move(transfer);
            return this;
        }
    }

    public class FMatrixJsonConverter : JsonConverter<FMatrix>
    {
        public override FMatrix Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => Supports.LARGE_WORLD_COORDINATES ? double.Parse(x, CultureInfo.InvariantCulture) : float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FMatrix();
            obj.XPlane = new FPlane(v[0], v[1], v[2], v[3]);
            obj.YPlane = new FPlane(v[4], v[5], v[6], v[7]);
            obj.ZPlane = new FPlane(v[8], v[9], v[10], v[11]);
            obj.WPlane = new FPlane(v[12], v[13], v[14], v[15]);
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FMatrix value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.XPlane.X} {value.XPlane.Y} {value.XPlane.Z} {value.XPlane.W} {value.YPlane.X} {value.YPlane.Y} {value.YPlane.Z} {value.YPlane.W} {value.ZPlane.X} {value.ZPlane.Y} {value.ZPlane.Z} {value.ZPlane.W} {value.WPlane.X} {value.WPlane.Y} {value.WPlane.Z} {value.WPlane.W}");
            writer.WriteStringValue(s);
        }
    }
}
