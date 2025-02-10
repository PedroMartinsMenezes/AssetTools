using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    #region Double
    [TransferibleStruct("Quat4d", "Quat", 32)]
    public class FQuat4d : ITransferible, IJsonConverter, ITagConverter, ITagSelector
    {
        public const string StructName = "Quat4d";
        public const int SIZE = 32;

        public double X;
        public double Y;
        public double Z;
        public double W;

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

        #region ITagSelector
        public string GetType(int size)
        {
            return "Quat4d";
        }
        public object GetValue(object value, int size)
        {
            return value;
        }
        #endregion
    }
    public class FQuat4dJsonConverter : JsonConverter<FQuat4d>
    {
        public override FQuat4d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FQuat4d { X = v[0], Y = v[1], Z = v[2], W = v[3] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FQuat4d value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z} {value.W}");
            writer.WriteStringValue(s);
        }
    }
    #endregion

    #region Float
    [TransferibleStruct("Quat4f", "Quat", 16)]
    public class FQuat4f : ITransferible, IJsonConverter, ITagConverter, ITagSelector
    {
        public const string StructName = "Quat4f";
        public const int SIZE = 16;

        public float X;
        public float Y;
        public float Z;
        public float W;

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

        #region ITagSelector
        public string GetType(int size)
        {
            return "Quat4f";
        }
        public object GetValue(object value, int size)
        {
            return value;
        }
        #endregion
    }
    public class FQuat4fJsonConverter : JsonConverter<FQuat4f>
    {
        public override FQuat4f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FQuat4f { X = v[0], Y = v[1], Z = v[2], W = v[3] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FQuat4f value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z} {value.W}");
            writer.WriteStringValue(s);
        }
    }
    #endregion

    #region Float or Double
    [TransferibleStruct("Quat", size1: 16, size2: 32)]
    public class FQuat : ITransferible, IJsonConverter, ITagConverter, ITagSelector
    {
        public double X;
        public double Y;
        public double Z;
        public double W;

        #region ITransferible
        public ITransferible Move(Transfer transfer)
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
            var v = value.ToString().Split(' ').Select(x => Supports.LARGE_WORLD_COORDINATES ? double.Parse(x, CultureInfo.InvariantCulture) : float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
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
        [JsonIgnore] public string TagName => "Quat";
        [JsonIgnore] public int TagSize => Supports.LARGE_WORLD_COORDINATES ? 32 : 16;
        public object TagRead(object elem)
        {
            return elem.ToObject<FQuat>();
        }
        #endregion

        #region ITagSelector
        public string GetType(int size)
        {
            return "Quat";
        }
        public object GetValue(object value, int size)
        {
            return value;
        }
        #endregion
    }
    public class FQuat4JsonConverter : JsonConverter<FQuat>
    {
        public override FQuat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => Supports.LARGE_WORLD_COORDINATES ? double.Parse(x, CultureInfo.InvariantCulture) : float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FQuat { X = v[0], Y = v[1], Z = v[2], W = v[3] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FQuat value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z} {value.W}");
            writer.WriteStringValue(s);
        }
    }
    #endregion
}
