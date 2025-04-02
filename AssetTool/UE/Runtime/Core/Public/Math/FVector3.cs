using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    #region Double
    [TransferibleStruct("Vector3d", "Vector", 24)]
    public class FVector3d : ITransferible, IJsonConverter, ITagConverter
    {
        public double X;
        public double Y;
        public double Z;

        public const string StructName = "Vector3d";
        public const int SIZE = 24;

        #region ITransferible
        public virtual ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
        #endregion

        #region ITagConverter
        public int TagSize(Transfer transfer) => 24;
        public object TagRead(object elem, Transfer transfer)
        {
            return elem.ToObject<FVector3d>(transfer);
        }
        #endregion
    }
    public class FVector3dJsonConverter : JsonConverter<FVector3d>
    {
        public override FVector3d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector3d { X = v[0], Y = v[1], Z = v[2] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector3d value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z}");
            writer.WriteStringValue(s);
        }
    }
    #endregion

    #region Float
    [TransferibleStruct("Vector3f", "Vector", 12)]
    public class FVector3f : ITransferible, IJsonConverter, ITagConverter
    {
        public float X;
        public float Y;
        public float Z;

        public const string StructName = "Vector3d";
        public const int SIZE = 12;

        #region ITransferible
        public virtual ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
        #endregion

        #region IJsonConverter
        ///public object JsonRead(object value)
        ///{
        ///    var v = value.ToString().Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
        ///    X = v[0];
        ///    Y = v[1];
        ///    Z = v[2];
        ///    return this;
        ///}
        ///public object JsonWrite()
        ///{
        ///    return $"{X} {Y} {Z}";
        ///}
        #endregion

        #region ITagConverter
        public int TagSize(Transfer transfer) => 12;
        public object TagRead(object elem, Transfer transfer)
        {
            return elem.ToObject<FVector3f>(transfer);
        }
        #endregion
    }
    public class FVector3fJsonConverter : JsonConverter<FVector3f>
    {
        public override FVector3f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector3f { X = v[0], Y = v[1], Z = v[2] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector3f value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z}");
            writer.WriteStringValue(s);
        }
    }
    #endregion

    #region Float or Double
    [TransferibleStruct("Vector", size1: 12, size2: 24)]
    public class FVector3 : ITransferible, IJsonConverter, ITagConverter, ITagSelector
    {
        public double X, Y, Z;

        #region ITransferible
        public virtual ITransferible Move(Transfer transfer)
        {
            if (transfer.Supports.LARGE_WORLD_COORDINATES)
            {
                transfer.Move(ref X);
                transfer.Move(ref Y);
                transfer.Move(ref Z);
            }
            else
            {
                X = transfer.Move((float)X);
                Y = transfer.Move((float)Y);
                Z = transfer.Move((float)Z);
            }
            return this;
        }
        #endregion

        #region ITagConverter
        public int TagSize(Transfer transfer) => transfer.Supports.LARGE_WORLD_COORDINATES ? 24 : 12;
        public object TagRead(object elem, Transfer transfer)
        {
            return elem.ToObject<FVector>(transfer);
        }
        #endregion

        #region ITagSelector
        public string GetType(int size)
        {
            return "Vector";
        }
        public object GetValue(object value, int size)
        {
            return value;
        }
        #endregion
    }
    public class FVector3JsonConverter : JsonConverter<FVector3>
    {
        public Transfer transfer;

        public FVector3JsonConverter SetTransfer(Transfer transfer)
        {
            this.transfer = transfer;
            return this;
        }

        public override FVector3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            return new FVector3 { X = v[0], Y = v[1], Z = v[2] };
        }

        public override void Write(Utf8JsonWriter writer, FVector3 value, JsonSerializerOptions options)
        {
            if (transfer.Supports.LARGE_WORLD_COORDINATES)
                writer.WriteStringValue(string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z}"));
            else
                writer.WriteStringValue(string.Create(CultureInfo.InvariantCulture, $"{(float)value.X} {(float)value.Y} {(float)value.Z}"));
        }
    }
    #endregion
}
