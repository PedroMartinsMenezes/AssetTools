using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    #region Double
    [TransferibleStruct("Vector3d", "Vector", 24)]
    [DebuggerDisplay("({X} {Y} {Z})")]
    public struct FVector3d : ITransferible, ITagConverter
    {
        public double X;
        public double Y;
        public double Z;

        public const string StructName = "Vector3d";
        public const int SIZE = 24;
        public bool IsZero() => X == 0 && Y == 0 && Z == 0;

        #region ITransferible
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
        #endregion

        #region ITagConverter
        public object DerivedToTag(object elem, Transfer transfer)
        {
            return elem.ToObject<FVector3d>(transfer);
        }
        #endregion
    }
    public class FVector3dJsonConverter : JsonConverter<FVector3d>
    {
        public override FVector3d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToDoubleArray();
            return new FVector3d { X = v[0], Y = v[1], Z = v[2] };
        }

        public override void Write(Utf8JsonWriter writer, FVector3d value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z}"));
        }
    }
    public class FVector3dArrayJsonConverter : JsonConverter<FVector3d[]>
    {
        public override FVector3d[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(" | ").Select(x => x.Split(' ') is var v ? new FVector3d { X = double.Parse(v[0], CultureInfo.InvariantCulture), Y = double.Parse(v[1], CultureInfo.InvariantCulture), Z = double.Parse(v[2], CultureInfo.InvariantCulture) } : default).ToArray() : [];
        }

        public override void Write(Utf8JsonWriter writer, FVector3d[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => string.Create(CultureInfo.InvariantCulture, $"{x.X} {x.Y} {x.Z}"))));
        }
    }
    public class FVector3dListJsonConverter : JsonConverter<List<FVector3d>>
    {
        public override List<FVector3d> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(" | ").Select(x => x.Split(' ') is var v ? new FVector3d { X = double.Parse(v[0], CultureInfo.InvariantCulture), Y = double.Parse(v[1], CultureInfo.InvariantCulture), Z = double.Parse(v[2], CultureInfo.InvariantCulture) } : default).ToList() : [];
        }

        public override void Write(Utf8JsonWriter writer, List<FVector3d> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => string.Create(CultureInfo.InvariantCulture, $"{x.X} {x.Y} {x.Z}"))));
        }
    }
    #endregion

    #region Float
    [TransferibleStruct("Vector3f", "Vector", 12)]
    [DebuggerDisplay("({X} {Y} {Z})")]
    public struct FVector3f : ITransferible, ITagConverter
    {
        public float X;
        public float Y;
        public float Z;

        public const string StructName = "Vector3f";
        public const int SIZE = 12;
        public bool IsZero() => X == 0 && Y == 0 && Z == 0;

        #region ITransferible
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
        #endregion

        #region ITagConverter
        public object DerivedToTag(object elem, Transfer transfer)
        {
            return elem.ToObject<FVector3f>(transfer);
        }
        #endregion

        public string GetString() => string.Create(CultureInfo.InvariantCulture, $"{X},{Y},{Z}");

        public static string GetString(List<FVector3f> v) => string.Join(" ", v.Select(x => x.GetString()));

        public static FVector3f FromString(string str)
        {
            var v = str.Split(',').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            return new FVector3f { X = v[0], Y = v[1], Z = v[2] };
        }
    }
    public class FVector3fJsonConverter : JsonConverter<FVector3f>
    {
        public override FVector3f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToFloatArray();
            return new FVector3f { X = v[0], Y = v[1], Z = v[2] };
        }

        public override void Write(Utf8JsonWriter writer, FVector3f value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z}");
            writer.WriteStringValue(s);
        }
    }
    public class FVector3fArrayJsonConverter : JsonConverter<FVector3f[]>
    {
        public override FVector3f[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(" | ").Select(x => x.Split(' ') is var v ? new FVector3f { X = float.Parse(v[0], CultureInfo.InvariantCulture), Y = float.Parse(v[1], CultureInfo.InvariantCulture), Z = float.Parse(v[2], CultureInfo.InvariantCulture) } : default).ToArray() : [];
        }

        public override void Write(Utf8JsonWriter writer, FVector3f[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => string.Create(CultureInfo.InvariantCulture, $"{x.X} {x.Y} {x.Z}"))));
        }
    }
    public class FVector3fListJsonConverter : JsonConverter<List<FVector3f>>
    {
        public override List<FVector3f> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(" | ").Select(x => x.Split(' ') is var v ? new FVector3f { X = float.Parse(v[0], CultureInfo.InvariantCulture), Y = float.Parse(v[1], CultureInfo.InvariantCulture), Z = float.Parse(v[2], CultureInfo.InvariantCulture) } : default).ToList() : [];
        }

        public override void Write(Utf8JsonWriter writer, List<FVector3f> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => string.Create(CultureInfo.InvariantCulture, $"{x.X} {x.Y} {x.Z}"))));
        }
    }
    #endregion

    #region Float or Double
    [TransferibleStruct("Vector", size1: 12, size2: 24)]
    [DebuggerDisplay("({X} {Y} {Z})")]
    public struct FVector3 : ITransferible, ITagConverter
    {
        public double X, Y, Z;

        #region ITransferible
        public ITransferible Move(Transfer transfer)
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
        public object DerivedToTag(object elem, Transfer transfer)
        {
            return elem.ToObject<FVector>(transfer);
        }
        #endregion
    }
    public class FVector3JsonConverter : JsonConverter<FVector3>
    {
        public override FVector3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToDoubleArray();
            return new FVector3 { X = v[0], Y = v[1], Z = v[2] };
        }

        public override void Write(Utf8JsonWriter writer, FVector3 value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z}"));
        }
    }
    #endregion
}
