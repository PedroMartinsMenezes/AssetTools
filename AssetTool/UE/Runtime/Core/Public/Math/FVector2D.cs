using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    #region Double
    [TransferableStruct("Vector2d", "Vector2D", 16)]
    [DebuggerDisplay("({X} {Y})")]
    public struct FVector2d : ITransferable, ITagConverter
    {
        public const string StructName = "Vector2d";
        public const int SIZE = 16;

        public double X;
        public double Y;

        #region ITransferable
        [Location("FArchive& operator<<(FArchive& Ar, TVector2<double>& V)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
        #endregion
    }
    public class FVector2dJsonConverter : JsonConverter<FVector2d>
    {
        public override FVector2d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToDoubleArray();
            var obj = new FVector2d { X = v[0], Y = v[1] };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FVector2d value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y}");
            writer.WriteStringValue(s);
        }
    }
    public class FVector2dArrayJsonConverter : JsonConverter<FVector2d[]>
    {
        public override FVector2d[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(" | ").Select(x => x.Split(' ') is var v ? new FVector2d { X = double.Parse(v[0], CultureInfo.InvariantCulture), Y = double.Parse(v[1], CultureInfo.InvariantCulture) } : default).ToArray() : [];
        }

        public override void Write(Utf8JsonWriter writer, FVector2d[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => string.Create(CultureInfo.InvariantCulture, $"{x.X} {x.Y}"))));
        }
    }
    public class FVector2dListJsonConverter : JsonConverter<List<FVector2d>>
    {
        public override List<FVector2d> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(" | ").Select(x => x.Split(' ') is var v ? new FVector2d { X = double.Parse(v[0], CultureInfo.InvariantCulture), Y = double.Parse(v[1], CultureInfo.InvariantCulture) } : default).ToList() : [];
        }

        public override void Write(Utf8JsonWriter writer, List<FVector2d> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => string.Create(CultureInfo.InvariantCulture, $"{x.X} {x.Y}"))));
        }
    }
    #endregion

    #region Float
    [TransferableStruct("Vector2f", "Vector2D", 8)]
    [DebuggerDisplay("({X} {Y})")]
    public struct FVector2f : ITransferable, ITagConverter
    {
        public const string StructName = "Vector2f";
        public const int SIZE = 8;

        public float X;
        public float Y;

        #region ITransferable
        [Location("FArchive& operator<<(FArchive& Ar, TVector2<double>& V)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
        #endregion
    }
    public class FVector2fJsonConverter : JsonConverter<FVector2f>
    {
        public override FVector2f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string[] v = reader.GetString().Split(' ');
            return new FVector2f { X = v[0].ToFloat(), Y = v[1].ToFloat() };
        }

        public override void Write(Utf8JsonWriter writer, FVector2f value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X.ToStr()} {value.Y.ToStr()}");
            writer.WriteStringValue(s);
        }
    }
    public class FVector2fArrayJsonConverter : JsonConverter<FVector2f[]>
    {
        public override FVector2f[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(" | ").Select(x => x.Split(' ') is var v ? new FVector2f { X = float.Parse(v[0], CultureInfo.InvariantCulture), Y = float.Parse(v[1], CultureInfo.InvariantCulture) } : default).ToArray() : [];
        }

        public override void Write(Utf8JsonWriter writer, FVector2f[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => string.Create(CultureInfo.InvariantCulture, $"{x.X.ToStr()} {x.Y.ToStr()}"))));
        }
    }
    public class FVector2fListJsonConverter : JsonConverter<List<FVector2f>>
    {
        public override List<FVector2f> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? reader.GetString().Split(" | ").Select(x => x.Split(' ') is var v ? new FVector2f { X = float.Parse(v[0], CultureInfo.InvariantCulture), Y = float.Parse(v[1], CultureInfo.InvariantCulture) } : default).ToList() : [];
        }

        public override void Write(Utf8JsonWriter writer, List<FVector2f> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => string.Create(CultureInfo.InvariantCulture, $"{x.X} {x.Y}"))));
        }
    }
    #endregion

    #region Float or Double
    [TransferableStruct("Vector2D", size1: 8, size2: 16)]
    [DebuggerDisplay("({X} {Y})")]
    public struct FVector2D : ITransferable, ITagConverter
    {
        public double X;
        public double Y;

        #region ITransferable
        public ITransferable Move(Transfer transfer)
        {
            transfer.MoveSingleOrDouble(ref X);
            transfer.MoveSingleOrDouble(ref Y);
            return this;
        }
        #endregion
    }
    public class FVector2JsonConverter : JsonConverter<FVector2D>
    {
        public override FVector2D Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToDoubleArray();
            return new FVector2D { X = v[0], Y = v[1] };
        }

        public override void Write(Utf8JsonWriter writer, FVector2D value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y}"));
        }
    }
    #endregion
}
