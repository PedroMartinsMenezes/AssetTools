using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    #region Double
    [TransferableStruct("Rotator3d", "Rotator", 24)]
    [DebuggerDisplay("Roll {Roll} Pitch {Pitch} Yaw {Yaw}")]
    public class FRotator3d : ITransferable, ITagConverter
    {
        public const string StructName = "Rotator3d";
        public const int SIZE = 24;

        public double Pitch;
        public double Yaw;
        public double Roll;

        #region ITransferable
        [Location("operator<<(FArchive& Ar, TRotator<double>& R)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Pitch);
            transfer.Move(ref Yaw);
            transfer.Move(ref Roll);
            return this;
        }
        #endregion
    }
    public class FRotator3dJsonConverter : JsonConverter<FRotator3d>
    {
        public override FRotator3d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToDoubleArray();
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
    [TransferableStruct("Rotator3f", "Rotator", 12)]
    [DebuggerDisplay("Roll {Roll} Pitch {Pitch} Yaw {Yaw}")]
    public class FRotator3f : ITransferable, ITagConverter
    {
        public const string StructName = "Rotator3f";
        public const int SIZE = 12;

        public float Pitch;
        public float Yaw;
        public float Roll;

        #region ITransferable
        [Location("operator<<(FArchive& Ar, TRotator<float>& R)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Pitch);
            transfer.Move(ref Yaw);
            transfer.Move(ref Roll);
            return this;
        }
        #endregion
    }
    public class FRotator3fJsonConverter : JsonConverter<FRotator3f>
    {
        public override FRotator3f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToFloatArray();
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
    [TransferableStruct("Rotator", size1: 12, size2: 24)]
    [DebuggerDisplay("Roll {Roll} Pitch {Pitch} Yaw {Yaw}")]
    public class FRotator : ITransferable, ITagConverter
    {
        public const string StructName = "Rotator";

        public double Pitch;
        public double Yaw;
        public double Roll;

        #region ITransferable
        [Location("operator<<(FArchive& Ar, TRotator<double>& R)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveSingleOrDouble(ref Pitch);
            transfer.MoveSingleOrDouble(ref Yaw);
            transfer.MoveSingleOrDouble(ref Roll);
            return this;
        }
        #endregion
    }
    public class FRotatorJsonConverter : JsonConverter<FRotator>
    {
        public override FRotator Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToDoubleArray();
            var obj = new FRotator { Pitch = v[0], Yaw = v[1], Roll = v[2] };
            return obj;
        }
        public override void Write(Utf8JsonWriter writer, FRotator value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Format("{0} {1} {2}", value.Pitch.ToString("G17"), value.Yaw.ToString("G17"), value.Roll.ToString("G17")));
        }
    }
    #endregion
}
