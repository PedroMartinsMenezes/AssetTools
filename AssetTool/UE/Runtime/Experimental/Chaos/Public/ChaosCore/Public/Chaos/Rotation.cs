using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool.Chaos
{
    [DebuggerDisplay("({X} {Y} {Z} {W})")]
    public class TRotation3d : ITransferable
    {
        public double X;
        public double Y;
        public double Z;
        public double W;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
    }

    public class TRotation3dJsonConverter : JsonConverter<TRotation3d>
    {
        public override TRotation3d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToDoubleArray();
            return new TRotation3d { X = v[0], Y = v[1], Z = v[2], W = v[3] };
        }

        public override void Write(Utf8JsonWriter writer, TRotation3d value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z} {value.W}"));
        }
    }

    [DebuggerDisplay("({X} {Y} {Z} {W})")]
    public class TRotation3f : ITransferable
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
    }

    public class TRotation3fJsonConverter : JsonConverter<TRotation3f>
    {
        public override TRotation3f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToFloatArray();
            return new TRotation3f { X = v[0], Y = v[1], Z = v[2], W = v[3] };
        }

        public override void Write(Utf8JsonWriter writer, TRotation3f value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z} {value.W}"));
        }
    }
}
