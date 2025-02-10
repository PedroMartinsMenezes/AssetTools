using System.Text.Json.Serialization;
using System.Text.Json;

namespace AssetTool
{
    #region Double
    [TransferibleStruct("Box2d", "Box2D", 33)]
    public class FBox2d : ITransferible, IJsonConverter, ITagConverter
    {
        public const int SIZE = 33;
        public FVector2d Min = new();
        public FVector2d Max = new();
        public byte IsValid;

        public ITransferible Move(Transfer transfer)
        {
            Min.Move(transfer);
            Max.Move(transfer);
            transfer.Move(ref IsValid);
            return this;
        }
        public object JsonRead(object value)
        {
            var v = value.ToString().Split(' ');
            Min.X = double.Parse(v[0]);
            Min.Y = double.Parse(v[1]);
            Max.X = double.Parse(v[2]);
            Max.Y = double.Parse(v[3]);
            IsValid = double.Parse(v[4]) > 0 ? (byte)1 : (byte)0;
            return this;
        }
        public object JsonWrite()
        {
            return $"{Min.X} {Min.Y} {Max.X} {Max.Y} {(double)IsValid}";
        }
        [JsonIgnore] public string TagName => "Box2d";
        [JsonIgnore] public int TagSize => 33;
        public object TagRead(object elem)
        {
            return elem.ToObject<FBox2d>();
        }
    }
    public class FBox2dJsonConverter : JsonConverter<FBox2d>
    {
        public override FBox2d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x)).ToArray();
            var obj = new FBox2d { Min = new() { X = v[0], Y = v[1] }, Max = new() { X = v[2], Y = v[3] }, IsValid = v[4] > 0 ? (byte)1 : (byte)0 };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FBox2d value, JsonSerializerOptions options)
        {
            string s = $"{value.Min.X} {value.Min.Y} {value.Max.X} {value.Max.Y} {(double)value.IsValid}";
            writer.WriteStringValue(s);
        }
    }
    #endregion

    #region Float
    [TransferibleStruct("Box2f", "Box2D", 17)]
    public class FBox2f : ITransferible, IJsonConverter, ITagConverter
    {
        public const int SIZE = 17;
        public FVector2f Min = new();
        public FVector2f Max = new();
        public byte IsValid;

        public ITransferible Move(Transfer transfer)
        {
            Min.Move(transfer);
            Max.Move(transfer);
            transfer.Move(ref IsValid);
            return this;
        }
        public object JsonRead(object value)
        {
            var v = value.ToString().Split(' ');
            Min.X = float.Parse(v[0]);
            Min.Y = float.Parse(v[1]);
            Max.X = float.Parse(v[2]);
            Max.Y = float.Parse(v[3]);
            IsValid = float.Parse(v[4]) > 0 ? (byte)1 : (byte)0;
            return this;
        }
        public object JsonWrite()
        {
            return $"{Min.X} {Min.Y} {Max.X} {Max.Y} {(float)IsValid}";
        }
        [JsonIgnore] public string TagName => "FBox2f";
        [JsonIgnore] public int TagSize => 3173;
        public object TagRead(object elem)
        {
            return elem.ToObject<FBox2f>();
        }
    }
    public class FBox2fJsonConverter : JsonConverter<FBox2f>
    {
        public override FBox2f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => float.Parse(x)).ToArray();
            var obj = new FBox2f { Min = new() { X = v[0], Y = v[1] }, Max = new() { X = v[2], Y = v[3] }, IsValid = v[4] > 0 ? (byte)1 : (byte)0 };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FBox2f value, JsonSerializerOptions options)
        {
            string s = $"{value.Min.X} {value.Min.Y} {value.Max.X} {value.Max.Y} {(float)value.IsValid}";
            writer.WriteStringValue(s);
        }
    }
    #endregion

    #region Float or Double
    [TransferibleStruct("Box2D", size1: 17, size2: 33)]
    public class FBox2D : ITransferible, IJsonConverter, ITagConverter
    {
        public const int SIZE = 33;
        public FVector2D Min = new();
        public FVector2D Max = new();
        public byte IsValid;

        public ITransferible Move(Transfer transfer)
        {
            Min.Move(transfer);
            Max.Move(transfer);
            transfer.Move(ref IsValid);
            return this;
        }
        public object JsonRead(object value)
        {
            var v = value.ToString().Split(' ');
            if (Supports.LARGE_WORLD_COORDINATES)
            {
                Min.X = double.Parse(v[0]);
                Min.Y = double.Parse(v[1]);
                Max.X = double.Parse(v[2]);
                Max.Y = double.Parse(v[3]);
                IsValid = double.Parse(v[4]) > 0 ? (byte)1 : (byte)0;
            }
            else
            {
                Min.X = float.Parse(v[0]);
                Min.Y = float.Parse(v[1]);
                Max.X = float.Parse(v[2]);
                Max.Y = float.Parse(v[3]);
                IsValid = float.Parse(v[4]) > 0 ? (byte)1 : (byte)0;
            }
            return this;
        }
        public object JsonWrite()
        {
            if (Supports.LARGE_WORLD_COORDINATES)
            {
                return $"{Min.X} {Min.Y} {Max.X} {Max.Y} {(double)IsValid}";
            }
            else
            {
                return $"{Min.X} {Min.Y} {Max.X} {Max.Y} {(float)IsValid}";
            }
        }
        [JsonIgnore] public string TagName => "Box2d";
        [JsonIgnore] public int TagSize => Supports.LARGE_WORLD_COORDINATES ? 33 : 17;
        public object TagRead(object elem)
        {
            return elem.ToObject<FBox2D>();
        }
    }
    public class FBox2DJsonConverter : JsonConverter<FBox2D>
    {
        public override FBox2D Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => Supports.LARGE_WORLD_COORDINATES ? double.Parse(x) : float.Parse(x)).ToArray();
            var obj = new FBox2D { Min = new() { X = v[0], Y = v[1] }, Max = new() { X = v[2], Y = v[3] }, IsValid = v[4] > 0 ? (byte)1 : (byte)0 };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FBox2D value, JsonSerializerOptions options)
        {
            if (Supports.LARGE_WORLD_COORDINATES)
            {
                writer.WriteStringValue($"{value.Min.X} {value.Min.Y} {value.Max.X} {value.Max.Y} {(double)value.IsValid}");
            }
            else
            {
                writer.WriteStringValue($"{value.Min.X} {value.Min.Y} {value.Max.X} {value.Max.Y} {(float)value.IsValid}");
            }
        }
    }
    #endregion
}
