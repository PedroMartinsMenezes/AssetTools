using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
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

    public class FVector2fArrayJsonConverter : JsonConverter<FVector2f[]>
    {
        public override FVector2f[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(" | ").Select(x => x.Split(' ') is var v ? new FVector2f { X = float.Parse(v[0]), Y = float.Parse(v[1]) } : default).ToArray();
        }

        public override void Write(Utf8JsonWriter writer, FVector2f[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.X} {x.Y}")));
        }
    }
    #endregion

    #region Float or Double
    [TransferibleStruct("Vector2D", size1: 8, size2: 16)]
    public class FVector2D : ITransferible, IJsonConverter, ITagConverter, ITagSelector
    {
        public double X;
        public double Y;

        #region ITransferible
        public virtual ITransferible Move(Transfer transfer)
        {
            if (Supports.LARGE_WORLD_COORDINATES)
            {
                transfer.Move(ref X);
                transfer.Move(ref Y);
            }
            else
            {
                X = transfer.Move((float)X);
                Y = transfer.Move((float)Y);
            }
            return this;
        }
        #endregion

        #region IJsonConverter
        public object JsonRead(object value)
        {
            var v = value.ToString().Split(' ').Select(x => Supports.LARGE_WORLD_COORDINATES ? double.Parse(x, CultureInfo.InvariantCulture) : float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            X = v[0];
            Y = v[1];
            return this;
        }
        public object JsonWrite()
        {
            return Supports.LARGE_WORLD_COORDINATES ? $"{X} {Y}" : (object)$"{(float)X} {(float)Y}";
        }
        #endregion

        #region ITagConverter
        [JsonIgnore] public string TagName => "Vector2D";
        [JsonIgnore] public int TagSize => Supports.LARGE_WORLD_COORDINATES ? 16 : 8;
        public object TagRead(object elem)
        {
            return elem.ToObject<FVector2D>();
        }
        #endregion

        #region ITagSelector
        public string GetType(int size)
        {
            return "Vector2D";
        }
        public object GetValue(object value, int size)
        {
            return value;
        }
        #endregion

    }
    public class FVector2JsonConverter : JsonConverter<FVector2D>
    {
        public override FVector2D Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => Supports.LARGE_WORLD_COORDINATES ? double.Parse(x, CultureInfo.InvariantCulture) : float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FVector2D { X = v[0], Y = v[1] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector2D value, JsonSerializerOptions options)
        {
            if (Supports.LARGE_WORLD_COORDINATES)
            {
                writer.WriteStringValue($"{value.X} {value.Y}");
            }
            else
            {
                writer.WriteStringValue($"{(float)value.X} {(float)value.Y}");
            }
        }
    }
    #endregion
}
