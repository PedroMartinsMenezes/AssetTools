using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace AssetTool
{
    #region Float
    [TransferibleStruct("Matrix44f", "Matrix", 64)]
    public class FMatrix44f : ITransferible, IJsonConverter, ITagConverter
    {
        public const int SIZE = 64;
        public float M11, M12, M13, M14, M21, M22, M23, M24, M31, M32, M33, M34, M41, M42, M43, M44;

        #region ITransferible
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref M11);
            transfer.Move(ref M12);
            transfer.Move(ref M13);
            transfer.Move(ref M14);
            transfer.Move(ref M21);
            transfer.Move(ref M22);
            transfer.Move(ref M23);
            transfer.Move(ref M24);
            transfer.Move(ref M31);
            transfer.Move(ref M32);
            transfer.Move(ref M33);
            transfer.Move(ref M34);
            transfer.Move(ref M41);
            transfer.Move(ref M42);
            transfer.Move(ref M43);
            transfer.Move(ref M44);
            return this;
        }
        #endregion

        #region IJsonConverter
        public object JsonRead(object value)
        {
            var v = value.ToString().Split(' ').Select(x => float.Parse(x)).ToArray();
            M11 = v[0];
            M12 = v[1];
            M13 = v[2];
            M14 = v[3];
            M21 = v[4];
            M22 = v[5];
            M23 = v[6];
            M24 = v[7];
            M31 = v[8];
            M32 = v[9];
            M33 = v[10];
            M34 = v[11];
            M41 = v[12];
            M42 = v[13];
            M43 = v[14];
            M44 = v[15];
            return this;
        }
        public object JsonWrite()
        {
            return $"{M11} {M12} {M13} {M14} {M21} {M22} {M23} {M24} {M31} {M32} {M33} {M34} {M41} {M42} {M43} {M44}";
        }
        #endregion

        #region ITagConverter
        [JsonIgnore] public string TagName => "Matrix44f";
        [JsonIgnore] public int TagSize => 64;
        public object TagRead(object elem)
        {
            return elem.ToObject<FMatrix44f>();
        }
        #endregion
    }

    public class FMatrix44fJsonConverter : JsonConverter<FMatrix44f>
    {
        public override FMatrix44f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => float.Parse(x)).ToArray();
            var obj = new FMatrix44f { M11 = v[0], M12 = v[1], M13 = v[2], M14 = v[3], M21 = v[4], M22 = v[5], M23 = v[6], M24 = v[7], M31 = v[8], M32 = v[9], M33 = v[10], M34 = v[11], M41 = v[12], M42 = v[13], M43 = v[14], M44 = v[15] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FMatrix44f value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.M11} {value.M12} {value.M13} {value.M14} {value.M21} {value.M22} {value.M23} {value.M24} {value.M31} {value.M32} {value.M33} {value.M34} {value.M41} {value.M42} {value.M43} {value.M44}");
            writer.WriteStringValue(s);
        }
    }
    #endregion

    #region Double
    [TransferibleStruct("Matrix44d", "Matrix", 128)]
    public class FMatrix44d : ITransferible, IJsonConverter, ITagConverter
    {
        public double M11, M12, M13, M14, M21, M22, M23, M24, M31, M32, M33, M34, M41, M42, M43, M44;

        #region ITransferible
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref M11);
            transfer.Move(ref M12);
            transfer.Move(ref M13);
            transfer.Move(ref M14);
            transfer.Move(ref M21);
            transfer.Move(ref M22);
            transfer.Move(ref M23);
            transfer.Move(ref M24);
            transfer.Move(ref M31);
            transfer.Move(ref M32);
            transfer.Move(ref M33);
            transfer.Move(ref M34);
            transfer.Move(ref M41);
            transfer.Move(ref M42);
            transfer.Move(ref M43);
            transfer.Move(ref M44);
            return this;
        }
        #endregion

        #region IJsonConverter
        public object JsonRead(object value)
        {
            var v = value.ToString().Split(' ').Select(x => double.Parse(x)).ToArray();
            M11 = v[0];
            M12 = v[1];
            M13 = v[2];
            M14 = v[3];
            M21 = v[4];
            M22 = v[5];
            M23 = v[6];
            M24 = v[7];
            M31 = v[8];
            M32 = v[9];
            M33 = v[10];
            M34 = v[11];
            M41 = v[12];
            M42 = v[13];
            M43 = v[14];
            M44 = v[15];
            return this;
        }
        public object JsonWrite()
        {
            return $"{M11} {M12} {M13} {M14} {M21} {M22} {M23} {M24} {M31} {M32} {M33} {M34} {M41} {M42} {M43} {M44}";
        }
        #endregion

        #region ITagConverter
        [JsonIgnore] public string TagName => "Matrix44d";
        [JsonIgnore] public int TagSize => 128;
        public object TagRead(object elem)
        {
            return elem.ToObject<FMatrix44d>();
        }
        #endregion
    }

    public class FMatrix44dJsonConverter : JsonConverter<FMatrix44d>
    {
        public override FMatrix44d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x)).ToArray();
            var obj = new FMatrix44d { M11 = v[0], M12 = v[1], M13 = v[2], M14 = v[3], M21 = v[4], M22 = v[5], M23 = v[6], M24 = v[7], M31 = v[8], M32 = v[9], M33 = v[10], M34 = v[11], M41 = v[12], M42 = v[13], M43 = v[14], M44 = v[15] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FMatrix44d value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.M11} {value.M12} {value.M13} {value.M14} {value.M21} {value.M22} {value.M23} {value.M24} {value.M31} {value.M32} {value.M33} {value.M34} {value.M41} {value.M42} {value.M43} {value.M44}");
            writer.WriteStringValue(s);
        }
    }
    #endregion

    #region Float or Double
    [TransferibleStruct("Matrix")]
    public class FMatrix : ITransferible, IJsonConverter
    {
        public double M11, M12, M13, M14, M21, M22, M23, M24, M31, M32, M33, M34, M41, M42, M43, M44;

        #region ITransferible
        public ITransferible Move(Transfer transfer)
        {
            if (Supports.LARGE_WORLD_COORDINATES)
            {
                transfer.Move(ref M11);
                transfer.Move(ref M12);
                transfer.Move(ref M13);
                transfer.Move(ref M14);
                transfer.Move(ref M21);
                transfer.Move(ref M22);
                transfer.Move(ref M23);
                transfer.Move(ref M24);
                transfer.Move(ref M31);
                transfer.Move(ref M32);
                transfer.Move(ref M33);
                transfer.Move(ref M34);
                transfer.Move(ref M41);
                transfer.Move(ref M42);
                transfer.Move(ref M43);
                transfer.Move(ref M44);
            }
            else
            {
                M11 = transfer.Move((float)M11);
                M12 = transfer.Move((float)M12);
                M13 = transfer.Move((float)M13);
                M14 = transfer.Move((float)M14);
                M21 = transfer.Move((float)M21);
                M22 = transfer.Move((float)M22);
                M23 = transfer.Move((float)M23);
                M24 = transfer.Move((float)M24);
                M31 = transfer.Move((float)M31);
                M32 = transfer.Move((float)M32);
                M33 = transfer.Move((float)M33);
                M34 = transfer.Move((float)M34);
                M41 = transfer.Move((float)M41);
                M42 = transfer.Move((float)M42);
                M43 = transfer.Move((float)M43);
                M44 = transfer.Move((float)M44);
            }
            return this;
        }
        #endregion

        #region IJsonConverter
        public object JsonRead(object value)
        {
            var v = value.ToString().Split(' ').Select(x => Supports.LARGE_WORLD_COORDINATES ? double.Parse(x) : float.Parse(x)).ToArray();
            M11 = v[0];
            M12 = v[1];
            M13 = v[2];
            M14 = v[3];
            M21 = v[4];
            M22 = v[5];
            M23 = v[6];
            M24 = v[7];
            M31 = v[8];
            M32 = v[9];
            M33 = v[10];
            M34 = v[11];
            M41 = v[12];
            M42 = v[13];
            M43 = v[14];
            M44 = v[15];
            return this;
        }
        public object JsonWrite()
        {
            if (Supports.LARGE_WORLD_COORDINATES)
            {
                return $"{M11} {M12} {M13} {M14} {M21} {M22} {M23} {M24} {M31} {M32} {M33} {M34} {M41} {M42} {M43} {M44}";
            }
            else
            {
                return $"{(float)M11} {(float)M12} {(float)M13} {(float)M14} {(float)M21} {(float)M22} {(float)M23} {(float)M24} {(float)M31} {(float)M32} {(float)M33} {(float)M34} {(float)M41} {(float)M42} {(float)M43} {(float)M44}";
            }
        }
        #endregion
    }

    public class FMatrixJsonConverter : JsonConverter<FMatrix>
    {
        public override FMatrix Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => Supports.LARGE_WORLD_COORDINATES ? double.Parse(x) : float.Parse(x)).ToArray();
            var obj = new FMatrix { M11 = v[0], M12 = v[1], M13 = v[2], M14 = v[3], M21 = v[4], M22 = v[5], M23 = v[6], M24 = v[7], M31 = v[8], M32 = v[9], M33 = v[10], M34 = v[11], M41 = v[12], M42 = v[13], M43 = v[14], M44 = v[15] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FMatrix value, JsonSerializerOptions options)
        {
            if (Supports.LARGE_WORLD_COORDINATES)
            {
                writer.WriteStringValue($"{value.M11} {value.M12} {value.M13} {value.M14} {value.M21} {value.M22} {value.M23} {value.M24} {value.M31} {value.M32} {value.M33} {value.M34} {value.M41} {value.M42} {value.M43} {value.M44}");
            }
            else
            {
                writer.WriteStringValue($"{(float)value.M11} {(float)value.M12} {(float)value.M13} {(float)value.M14} {(float)value.M21} {(float)value.M22} {(float)value.M23} {(float)value.M24} {(float)value.M31} {(float)value.M32} {(float)value.M33} {(float)value.M34} {(float)value.M41} {(float)value.M42} {(float)value.M43} {(float)value.M44}");
            }
        }
    }
    #endregion
}
