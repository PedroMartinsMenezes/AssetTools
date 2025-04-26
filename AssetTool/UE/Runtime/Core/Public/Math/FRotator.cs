using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    #region Double
    [TransferibleStruct("Rotator3d", "Rotator", 24)]
    public class FRotator3d : ITransferible, ITagConverter
    {
        public const string StructName = "Rotator3d";
        public const int SIZE = 24;

        public double Pitch;
        public double Yaw;
        public double Roll;

        #region ITransferible
        [Location("operator<<(FArchive& Ar, TRotator<double>& R)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Pitch);
            transfer.Move(ref Yaw);
            transfer.Move(ref Roll);
            return this;
        }
        #endregion

        #region ITagConverter
        public int TagSize(Transfer transfer) => 24;
        public object TagRead(object elem, Transfer transfer)
        {
            return elem.ToObject<FRotator3d>(transfer);
        }
        #endregion
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
    [TransferibleStruct("Rotator3f", "Rotator", 12)]
    public class FRotator3f : ITransferible, ITagConverter
    {
        public const string StructName = "Rotator3f";
        public const int SIZE = 12;

        public float Pitch;
        public float Yaw;
        public float Roll;

        #region ITransferible
        [Location("operator<<(FArchive& Ar, TRotator<float>& R)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Pitch);
            transfer.Move(ref Yaw);
            transfer.Move(ref Roll);
            return this;
        }
        #endregion

        #region ITagConverter
        public int TagSize(Transfer transfer) => 12;
        public object TagRead(object elem, Transfer transfer)
        {
            return elem.ToObject<FRotator3f>(transfer);
        }
        #endregion
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

    #region Float or Double
    [TransferibleStruct("Rotator", size1: 12, size2: 24)]
    public class FRotator : ITransferible, ITagConverter
    {
        public const string StructName = "Rotator";

        public double Pitch;
        public double Yaw;
        public double Roll;

        #region ITransferible
        [Location("operator<<(FArchive& Ar, TRotator<double>& R)")]
        public ITransferible Move(Transfer transfer)
        {
            if (transfer.Supports.LARGE_WORLD_COORDINATES)
            {
                transfer.Move(ref Pitch);
                transfer.Move(ref Yaw);
                transfer.Move(ref Roll);
            }
            else
            {
                Pitch = transfer.Move((float)Pitch);
                Yaw = transfer.Move((float)Yaw);
                Roll = transfer.Move((float)Roll);
            }
            return this;
        }
        #endregion

        #region ITagConverter
        public int TagSize(Transfer transfer) => transfer.Supports.LARGE_WORLD_COORDINATES ? 24 : 12;
        public object TagRead(object elem, Transfer transfer)
        {
            return elem.ToObject<FRotator>(transfer);
        }
        #endregion
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
            writer.WriteStringValue(string.Create(CultureInfo.InvariantCulture, $"{value.Pitch} {value.Yaw} {value.Roll}"));
        }
    }
    #endregion
}
