using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace AssetTool
{
    [StructSerializable("Rotator")]
    public class FRotatorSelector : ITransferibleSelector
    {
        public const string StructName = "Rotator";

        public object Move(Transfer transfer, int num, object value)
        {
            return num == FRotator3f.SIZE ? value.ToObject<FRotator3f>().Move(transfer) : value.ToObject<FRotator3d>().Move(transfer);
        }
    }

    #region Double
    [StructSerializable("Rotator3d")]
    public class FRotator3d : ITransferible
    {
        public const string StructName = "Rotator3d";
        public const int SIZE = 24;

        public double Pitch;
        public double Yaw;
        public double Roll;

        [Location("operator<<(FArchive& Ar, TRotator<double>& R)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Pitch);
            transfer.Move(ref Yaw);
            transfer.Move(ref Roll);
            return this;
        }
    }

    public class FRotator3dJsonConverter : JsonConverter<FRotator3d>
    {
        public override FRotator3d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FRotator3d { Pitch = v[0], Yaw = v[1], Roll = v[2] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FRotator3d value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.Pitch} {value.Yaw} {value.Roll}");
            writer.WriteStringValue(s);
        }
    }
    #endregion

    #region Float
    [StructSerializable("Rotator3f")]
    public class FRotator3f : ITransferible
    {
        public const string StructName = "Rotator3f";
        public const int SIZE = 12;

        public float Pitch;
        public float Yaw;
        public float Roll;

        [Location("operator<<(FArchive& Ar, TRotator<float>& R)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Pitch);
            transfer.Move(ref Yaw);
            transfer.Move(ref Roll);
            return this;
        }
    }

    public class FRotator3fJsonConverter : JsonConverter<FRotator3f>
    {
        public override FRotator3f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FRotator3f { Pitch = v[0], Yaw = v[1], Roll = v[2] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FRotator3f value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.Pitch} {value.Yaw} {value.Roll}");
            writer.WriteStringValue(s);
        }
    }
    #endregion
}
