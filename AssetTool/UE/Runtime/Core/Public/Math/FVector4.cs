using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [TransferibleStruct("Vector4", "Vector4f", 16, "Vector4d", 32)]
    public class FVector4Selector : ITransferibleSelector, ITagSelector
    {
        public const string StructName = "Vector4";

        public object Move(Transfer transfer, int num, object value)
        {
            return num == FVector4f.SIZE ? value.ToObject<FVector4f>().Move(transfer) : value.ToObject<FVector4d>().Move(transfer);
        }

        public string GetType(int size)
        {
            return size == FVector4f.SIZE ? "Vector4f" : "Vector4d";
        }

        public object GetValue(object value, int size)
        {
            return value;
        }
    }

    #region Double
    [TransferibleStruct("Vector4d", "Vector4", 32)]
    public class FVector4d : ITransferible, IJsonConverter, ITagConverter
    {
        public double X;
        public double Y;
        public double Z;
        public double W;

        public const string StructName = "Vector4d";
        public const int SIZE = 32;

        #region ITransferible
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
        #endregion

        #region IJsonConverter
        public object JsonRead(object value)
        {
            var v = value.ToString().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            X = v[0];
            Y = v[1];
            Z = v[2];
            W = v[3];
            return this;
        }
        public object JsonWrite()
        {
            return $"{X} {Y} {Z} {W}";
        }
        #endregion

        #region ITagConverter
        [JsonIgnore] public string TagName => "Vector4d";
        [JsonIgnore] public int TagSize => 32;
        public object TagRead(object elem)
        {
            return elem.ToObject<FVector4d>();
        }
        #endregion
    }
    public class FVector4dJsonConverter : JsonConverter<FVector4d>
    {
        public override FVector4d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector4d { X = v[0], Y = v[1], Z = v[2], W = v[3] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector4d value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z} {value.W}");
            writer.WriteStringValue(s);
        }
    }
    #endregion

    #region Float
    [TransferibleStruct("Vector4f", "Vector4", 16)]
    public class FVector4f : ITransferible, IJsonConverter, ITagConverter
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        public const string StructName = "Vector4f";
        public const int SIZE = 16;

        public FVector4f() { }

        #region ITransferible
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
        #endregion

        #region IJsonConverter
        public object JsonRead(object value)
        {
            var v = value.ToString().Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            X = v[0];
            Y = v[1];
            Z = v[2];
            W = v[3];
            return this;
        }
        public object JsonWrite()
        {
            return $"{X} {Y} {Z} {W}";
        }
        #endregion

        #region ITagConverter
        [JsonIgnore] public string TagName => "Vector4f";
        [JsonIgnore] public int TagSize => 16;
        public object TagRead(object elem)
        {
            return elem.ToObject<FVector4f>();
        }
        #endregion
    }
    public class FVector4fJsonConverter : JsonConverter<FVector4f>
    {
        public override FVector4f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector4f { X = v[0], Y = v[1], Z = v[2], W = v[3] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector4f value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z} {value.W}");
            writer.WriteStringValue(s);
        }
    }
    #endregion
}
