using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    #region Float
    [TransferibleStruct("Matrix44f", "Matrix", 64)]
    [DebuggerDisplay("Row1({M11} {M12} {M13} {M14}) Row2({M21} {M22} {M23} {M24}) Row3({M31} {M32} {M33} {M34}) Row4({M41} {M42} {M43} {M44})")]
    public class FMatrix44f : ITransferible, ITagConverter
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

        #region ITagConverter
        public object DerivedToTag(object elem, Transfer transfer)
        {
            return elem.ToObject<FMatrix44f>(transfer);
        }
        #endregion
    }

    public class FMatrix44fJsonConverter : JsonConverter<FMatrix44f>
    {
        public override FMatrix44f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToFloatArray();
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
    [DebuggerDisplay("Row1({M11} {M12} {M13} {M14}) Row2({M21} {M22} {M23} {M24}) Row3({M31} {M32} {M33} {M34}) Row4({M41} {M42} {M43} {M44})")]
    public class FMatrix44d : ITransferible, ITagConverter
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

        #region ITagConverter
        public object DerivedToTag(object elem, Transfer transfer)
        {
            return elem.ToObject<FMatrix44d>(transfer);
        }
        #endregion
    }

    public class FMatrix44dJsonConverter : JsonConverter<FMatrix44d>
    {
        public override FMatrix44d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToDoubleArray();
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
    [DebuggerDisplay("Row1({M11} {M12} {M13} {M14}) Row2({M21} {M22} {M23} {M24}) Row3({M31} {M32} {M33} {M34}) Row4({M41} {M42} {M43} {M44})")]
    public class FMatrix : ITransferible
    {
        public double M11, M12, M13, M14, M21, M22, M23, M24, M31, M32, M33, M34, M41, M42, M43, M44;

        #region ITransferible
        public ITransferible Move(Transfer transfer)
        {
            transfer.MoveSingleOrDouble(ref M11);
            transfer.MoveSingleOrDouble(ref M12);
            transfer.MoveSingleOrDouble(ref M13);
            transfer.MoveSingleOrDouble(ref M14);
            transfer.MoveSingleOrDouble(ref M21);
            transfer.MoveSingleOrDouble(ref M22);
            transfer.MoveSingleOrDouble(ref M23);
            transfer.MoveSingleOrDouble(ref M24);
            transfer.MoveSingleOrDouble(ref M31);
            transfer.MoveSingleOrDouble(ref M32);
            transfer.MoveSingleOrDouble(ref M33);
            transfer.MoveSingleOrDouble(ref M34);
            transfer.MoveSingleOrDouble(ref M41);
            transfer.MoveSingleOrDouble(ref M42);
            transfer.MoveSingleOrDouble(ref M43);
            transfer.MoveSingleOrDouble(ref M44);
            return this;
        }
        #endregion
    }

    public class FMatrixJsonConverter : JsonConverter<FMatrix>
    {
        public override FMatrix Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToDoubleArray();
            var obj = new FMatrix { M11 = v[0], M12 = v[1], M13 = v[2], M14 = v[3], M21 = v[4], M22 = v[5], M23 = v[6], M24 = v[7], M31 = v[8], M32 = v[9], M33 = v[10], M34 = v[11], M41 = v[12], M42 = v[13], M43 = v[14], M44 = v[15] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FMatrix value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Create(CultureInfo.InvariantCulture, $"{value.M11} {value.M12} {value.M13} {value.M14} {value.M21} {value.M22} {value.M23} {value.M24} {value.M31} {value.M32} {value.M33} {value.M34} {value.M41} {value.M42} {value.M43} {value.M44}"));
        }
    }
    #endregion
}
