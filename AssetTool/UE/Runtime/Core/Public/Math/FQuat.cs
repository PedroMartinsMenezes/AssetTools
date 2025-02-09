using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [TransferibleStruct("Quat", "Quat4f", 16, "Quat4d", 32)]
    public class FQuat4Selector : ITransferibleSelector, ITagSelector
    {
        public const string StructName = "Quat";

        public object Move(Transfer transfer, int num, object value)
        {
            return num == FQuat4f.SIZE ? value.ToObject<FQuat4f>().Move(transfer) : value.ToObject<FQuat4d>().Move(transfer);
        }

        public string GetType(int size)
        {
            return size == FQuat4f.SIZE ? "Quat4f" : "Quat4d";
        }

        public object GetValue(object value, int size)
        {
            return value;
        }
    }

    #region Double
    [TransferibleStruct("Quat4d", "Quat", 32)]
    public class FQuat4d : ITransferible, IJsonConverter, ITagConverter
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
    public class FQuat4f : ITransferible, IJsonConverter, ITagConverter
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
    [TransferibleStruct("Quat4", "Quat4", 32)]
    public class FQuat : ITransferible, IJsonConverter
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
