using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [TransferibleStruct("Vector2D", "Vector2f", 8, "Vector2d", 16)]
    public class FVector2Selector : ITransferibleSelector, ITagSelector
    {
        public const string StructName = "Vector2D";

        public object Move(Transfer transfer, int num, object value)
        {
            return num == FVector2f.SIZE ? value.ToObject<FVector2f>().Move(transfer) : value.ToObject<FVector2d>().Move(transfer);
        }

        public string GetType(int size)
        {
            return size == FVector2f.SIZE ? "Vector2f" : "Vector2d";
        }

        public object GetValue(object value, int size)
        {
            return value;
        }
    }

    #region Double
    [TransferibleStruct("Vector2d", "Vector2D", 16)]
    public class FVector2d : ITransferible, IJsonConverter, ITagConverter
    {
        public const string StructName = "Vector2d";
        public const int SIZE = 16;

        public double X;
        public double Y;

        #region ITransferible
        [Location("FArchive& operator<<(FArchive& Ar, TVector2<double>& V)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
        #endregion

        #region IJsonConverter
        public object JsonRead(object value)
        {
            var v = value.ToString().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            X = v[0];
            Y = v[1];
            return this;
        }
        public object JsonWrite()
        {
            return $"{X} {Y}";
        }
        #endregion

        #region ITagConverter
        [JsonIgnore] public string TagName => "Vector2d";
        [JsonIgnore] public int TagSize => 16;
        public object TagRead(object elem)
        {
            return elem.ToObject<FVector2d>();
        }
        #endregion
    }
    public class FVector2dJsonConverter : JsonConverter<FVector2d>
    {
        public override FVector2d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector2d { X = v[0], Y = v[1] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector2d value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y}");
            writer.WriteStringValue(s);
        }
    }
    #endregion

    #region Float
    [TransferibleStruct("Vector2f", "Vector2D", 8)]
    public class FVector2f : ITransferible, IJsonConverter, ITagConverter
    {
        public const string StructName = "Vector2f";
        public const int SIZE = 8;

        public float X;
        public float Y;

        public FVector2f() { }

        #region ITransferible
        [Location("FArchive& operator<<(FArchive& Ar, TVector2<double>& V)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
        #endregion

        #region IJsonConverter
        public object JsonRead(object value)
        {
            var v = value.ToString().Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            X = v[0];
            Y = v[1];
            return this;
        }
        public object JsonWrite()
        {
            return $"{X} {Y}";
        }
        #endregion

        #region ITagConverter
        [JsonIgnore] public string TagName => "Vector2f";
        [JsonIgnore] public int TagSize => 8;
        public object TagRead(object elem)
        {
            return elem.ToObject<FVector2f>();
        }
        #endregion
    }
    public class FVector2fJsonConverter : JsonConverter<FVector2f>
    {
        public override FVector2f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector2f { X = v[0], Y = v[1] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector2f value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y}");
            writer.WriteStringValue(s);
        }
    }
    #endregion
}
