using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
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

    #region Float or Double
    [TransferibleStruct("Vector4", size1: 16, size2: 32)]
    public class FVector4 : ITransferible, IJsonConverter, ITagConverter, ITagSelector
    {
        public double X;
        public double Y;
        public double Z;
        public double W;

        #region ITransferible
        public virtual ITransferible Move(Transfer transfer)
        {
            if (Supports.LARGE_WORLD_COORDINATES)
            {
                transfer.Move(ref X);
                transfer.Move(ref Y);
                transfer.Move(ref Z);
                transfer.Move(ref W);
            }
            else
            {
                X = transfer.Move((float)X);
                Y = transfer.Move((float)Y);
                Z = transfer.Move((float)Z);
                W = transfer.Move((float)W);
            }
            return this;
        }
        #endregion

        #region IJsonConverter
        public object JsonRead(object value)
        {
            var v = value.ToString().Split(' ').Select(x => Supports.LARGE_WORLD_COORDINATES ? double.Parse(x) : float.Parse(x)).ToArray();
            X = v[0];
            Y = v[1];
            Z = v[2];
            W = v[3];
            return this;
        }
        public object JsonWrite()
        {
            if (Supports.LARGE_WORLD_COORDINATES)
            {
                return $"{X} {Y} {Z} {W}";
            }
            else
            {
                return $"{(float)X} {(float)Y} {(float)Z} {(float)W}";
            }
        }
        #endregion

        #region ITagConverter
        [JsonIgnore] public string TagName => "Vector4";
        [JsonIgnore] public int TagSize => Supports.LARGE_WORLD_COORDINATES ? 32 : 16;
        public object TagRead(object elem)
        {
            return elem.ToObject<FVector>();
        }
        #endregion

        #region ITagSelector
        public string GetType(int size)
        {
            return "Vector4";
        }
        public object GetValue(object value, int size)
        {
            return value;
        }
        #endregion
    }
    public class FVector4JsonConverter : JsonConverter<FVector4>
    {
        public override FVector4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => Supports.LARGE_WORLD_COORDINATES ? double.Parse(x) : float.Parse(x)).ToArray();
            var obj = new FVector4 { X = v[0], Y = v[1], Z = v[2], W = v[3] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector4 value, JsonSerializerOptions options)
        {
            if (Supports.LARGE_WORLD_COORDINATES)
            {
                writer.WriteStringValue($"{value.X} {value.Y} {value.Z} {value.W}");
            }
            else
            {
                writer.WriteStringValue($"{(float)value.X} {(float)value.Y} {(float)value.Z} {(float)value.W}");
            }
        }
    }
    #endregion
}
