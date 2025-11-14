using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    #region Double
    [TransferableStruct("Quat4d", "Quat", 32)]
    [DebuggerDisplay("({X} {Y} {Z} {W})")]
    public struct FQuat4d : ITransferable, ITagConverter
    {
        public const string StructName = "Quat4d";
        public const int SIZE = 32;
        public bool IsZero() => X == 0 && Y == 0 && Z == 0 && W == 0;

        public double X;
        public double Y;
        public double Z;
        public double W;

        #region ITransferable
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
        #endregion
    }
    public class FQuat4dJsonConverter : JsonConverter<FQuat4d>
    {
        public override FQuat4d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToDoubleArray();
            return new FQuat4d { X = v[0], Y = v[1], Z = v[2], W = v[3] };
        }

        public override void Write(Utf8JsonWriter writer, FQuat4d value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z} {value.W}");
            writer.WriteStringValue(s);
        }
    }
    public class FQuat4dArrayJsonConverter : JsonConverter<FQuat4d[]>
    {
        public override FQuat4d[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(" | ").Select(x => x.Split(' ') is var v ? new FQuat4d { X = double.Parse(v[0], CultureInfo.InvariantCulture), Y = double.Parse(v[1], CultureInfo.InvariantCulture), Z = double.Parse(v[2], CultureInfo.InvariantCulture), W = double.Parse(v[3], CultureInfo.InvariantCulture) } : default).ToArray() : [];
        }

        public override void Write(Utf8JsonWriter writer, FQuat4d[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => string.Create(CultureInfo.InvariantCulture, $"{x.X} {x.Y} {x.Z} {x.W}"))));
        }
    }
    public class FQuat4dListJsonConverter : JsonConverter<List<FQuat4d>>
    {
        public override List<FQuat4d> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(" | ").Select(x => x.Split(' ') is var v ? new FQuat4d { X = double.Parse(v[0], CultureInfo.InvariantCulture), Y = double.Parse(v[1], CultureInfo.InvariantCulture), Z = double.Parse(v[2], CultureInfo.InvariantCulture), W = double.Parse(v[3], CultureInfo.InvariantCulture) } : default).ToList() : [];
        }

        public override void Write(Utf8JsonWriter writer, List<FQuat4d> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => string.Create(CultureInfo.InvariantCulture, $"{x.X} {x.Y} {x.Z} {x.W}"))));
        }
    }
    #endregion

    #region Float
    [TransferableStruct("Quat4f", "Quat", 16)]
    [DebuggerDisplay("({X} {Y} {Z} {W})")]
    public struct FQuat4f : ITransferable, ITagConverter
    {
        public const string StructName = "Quat4f";
        public const int SIZE = 16;
        public bool IsZero() => X == 0 && Y == 0 && Z == 0 && W == 0;

        public float X;
        public float Y;
        public float Z;
        public float W;

        #region ITransferable
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
        #endregion

        public string GetString() => string.Create(CultureInfo.InvariantCulture, $"{X},{Y},{Z},{W}");

        public static string GetString(List<FQuat4f> v) => string.Join(" ", v.Select(x => x.GetString()));

        public static FQuat4f FromString(string str)
        {
            var v = str.Split(',').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            return new FQuat4f { X = v[0], Y = v[1], Z = v[2], W = v[3] };
        }
    }
    public class FQuat4fJsonConverter : JsonConverter<FQuat4f>
    {
        public override FQuat4f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToFloatArray();
            return new FQuat4f { X = v[0], Y = v[1], Z = v[2], W = v[3] };
        }

        public override void Write(Utf8JsonWriter writer, FQuat4f value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z} {value.W}");
            writer.WriteStringValue(s);
        }
    }
    public class FQuat4fArrayJsonConverter : JsonConverter<FQuat4f[]>
    {
        public override FQuat4f[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(" | ").Select(x => x.Split(' ') is var v ? new FQuat4f { X = float.Parse(v[0], CultureInfo.InvariantCulture), Y = float.Parse(v[1], CultureInfo.InvariantCulture), Z = float.Parse(v[2], CultureInfo.InvariantCulture), W = float.Parse(v[3], CultureInfo.InvariantCulture) } : default).ToArray();
        }

        public override void Write(Utf8JsonWriter writer, FQuat4f[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => string.Create(CultureInfo.InvariantCulture, $"{x.X} {x.Y} {x.Z} {x.W}"))));
        }
    }
    public class FQuat4fListJsonConverter : JsonConverter<List<FQuat4f>>
    {
        public override List<FQuat4f> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(" | ").Select(x => x.Split(' ') is var v ? new FQuat4f { X = float.Parse(v[0], CultureInfo.InvariantCulture), Y = float.Parse(v[1], CultureInfo.InvariantCulture), Z = float.Parse(v[2], CultureInfo.InvariantCulture), W = float.Parse(v[3], CultureInfo.InvariantCulture) } : default).ToList();
        }

        public override void Write(Utf8JsonWriter writer, List<FQuat4f> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => string.Create(CultureInfo.InvariantCulture, $"{x.X} {x.Y} {x.Z} {x.W}"))));
        }
    }
    #endregion

    #region Float or Double
    [TransferableStruct("Quat", size1: 16, size2: 32)]
    [DebuggerDisplay("({X} {Y} {Z} {W})")]
    public struct FQuat : ITransferable, ITagConverter
    {
        [JsonIgnore] public bool IsDouble;
        public double X;
        public double Y;
        public double Z;
        public double W;

        #region ITransferable
        public ITransferable Move(Transfer transfer)
        {
            IsDouble = transfer.Supports.LARGE_WORLD_COORDINATES;
            transfer.MoveSingleOrDouble(ref X);
            transfer.MoveSingleOrDouble(ref Y);
            transfer.MoveSingleOrDouble(ref Z);
            transfer.MoveSingleOrDouble(ref W);
            return this;
        }

        public override string ToString()
        {
            return string.Create(CultureInfo.InvariantCulture, $"{X.ToStr(IsDouble)} {Y.ToStr(IsDouble)} {Z.ToStr(IsDouble)} {W.ToStr(IsDouble)}");
        }
        #endregion
    }
    public class FQuatJsonConverter : JsonConverter<FQuat>
    {
        public override FQuat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToDoubleArray();
            return new FQuat { X = v[0], Y = v[1], Z = v[2], W = v[3] };
        }

        public override void Write(Utf8JsonWriter writer, FQuat value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
    #endregion
}
