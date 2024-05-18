using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public static class FRotatorSelector
    {
        public const string StructName = "Rotator";

        public static object Move(Transfer transfer, int num, object value)
        {
            return num == FRotator.SIZE ? value.ToObject<FRotator>().Move(transfer) : value.ToObject<FRotatorf>().Move(transfer);
        }
    }

    [Location("operator<<(FArchive& Ar, TRotator<double>& R)")]
    public class FRotator
    {
        public const string StructName = "Rotator";
        public const int SIZE = 24;

        public double Pitch;
        public double Yaw;
        public double Roll;

        public FRotator Move(Transfer transfer)
        {
            transfer.Move(ref Pitch);
            transfer.Move(ref Yaw);
            transfer.Move(ref Roll);
            return this;
        }
    }

    [Location("?")]
    public class FRotatorf
    {
        public const string StructName = "Rotator";
        public const int SIZE = 12;

        public float Pitch;
        public float Yaw;
        public float Roll;

        public FRotatorf Move(Transfer transfer)
        {
            transfer.Move(ref Pitch);
            transfer.Move(ref Yaw);
            transfer.Move(ref Roll);
            return this;
        }
    }

    public class FRotatorJsonConverter : JsonConverter<FRotator>
    {
        public override FRotator Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FRotator { Pitch = v[0], Yaw = v[1], Roll = v[2] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FRotator value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.Pitch} {value.Yaw} {value.Roll}");
            writer.WriteStringValue(s);
        }
    }

    public class FRotatorfJsonConverter : JsonConverter<FRotatorf>
    {
        public override FRotatorf Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FRotatorf { Pitch = v[0], Yaw = v[1], Roll = v[2] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FRotatorf value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.Pitch} {value.Yaw} {value.Roll}");
            writer.WriteStringValue(s);
        }
    }
}
