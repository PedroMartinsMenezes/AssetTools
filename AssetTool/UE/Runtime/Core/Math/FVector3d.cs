using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public static class FVector3DSelector
    {
        public const string StructName = "Vector";

        public static object Move(Transfer transfer, int num, object value)
        {
            return num == FVector3Df.SIZE ? value.ToObject<FVector3Df>().Move(transfer) : value.ToObject<FVector3D>().Move(transfer);
        }
    }

    #region Double
    [Location("?")]
    public class FVector3D
    {
        public double X;
        public double Y;
        public double Z;

        public const string StructName = "Vector";
        public const int SIZE = 24;

        public FVector3D() { }

        public FVector3D Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
    }

    public class FVector3DJsonConverter : JsonConverter<FVector3D>
    {
        public override FVector3D Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector3D { X = v[0], Y = v[1], Z = v[2] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector3D value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z}");
            writer.WriteStringValue(s);
        }
    }
    #endregion

    #region Float
    public class FVector3Df
    {
        public float X;
        public float Y;
        public float Z;

        public const string StructName = "Vector";
        public const int SIZE = 12;

        public FVector3Df() { }

        public FVector3Df Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
    }

    public class FVector3DfJsonConverter : JsonConverter<FVector3Df>
    {
        public override FVector3Df Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector3Df { X = v[0], Y = v[1], Z = v[2] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector3Df value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z}");
            writer.WriteStringValue(s);
        }
    }
    #endregion
}
