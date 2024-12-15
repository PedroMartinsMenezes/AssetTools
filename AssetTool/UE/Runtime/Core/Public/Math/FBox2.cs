using System.Text.Json.Serialization;
using System.Text.Json;

namespace AssetTool
{
    [TransferibleStruct("Box2D", "Box2f", 17, "Box2d", 33)]
    public class FBox2DSelector : ITransferibleSelector, ITagSelector
    {
        public const string StructName = "Box2D";

        public object Move(Transfer transfer, int num, object value)
        {
            return num == FBox2f.SIZE ? value.ToObject<FBox2f>().Move(transfer) : value.ToObject<FBox2d>().Move(transfer);
        }

        public string GetType(int size)
        {
            return size == FBox2f.SIZE ? "Box2f" : "Box2d";
        }

        public object GetValue(object value, int size)
        {
            return value;
        }
    }

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
            IsValid = bool.Parse(v[4]) ? (byte)1 : (byte)0;
            return this;
        }
        public object JsonWrite()
        {
            return $"{Min.X} {Min.Y} {Max.X} {Max.Y} {IsValid == 1}";
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
            var v = reader.GetString().Split(' ');
            var obj = new FBox2d { Min = new() { X = double.Parse(v[0]), Y = double.Parse(v[1]) }, Max = new() { X = double.Parse(v[2]), Y = double.Parse(v[3]) }, IsValid = bool.Parse(v[4]) ? (byte)1 : (byte)0 };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FBox2d value, JsonSerializerOptions options)
        {
            string s = $"{value.Min.X} {value.Min.Y} {value.Max.X} {value.Max.Y} {value.IsValid == 1}";
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
            IsValid = bool.Parse(v[4]) ? (byte)1 : (byte)0;
            return this;
        }
        public object JsonWrite()
        {
            return $"{Min.X} {Min.Y} {Max.X} {Max.Y} {IsValid == 1}";
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
            var v = reader.GetString().Split(' ');
            var obj = new FBox2f { Min = new() { X = float.Parse(v[0]), Y = float.Parse(v[1]) }, Max = new() { X = float.Parse(v[2]), Y = float.Parse(v[3]) }, IsValid = bool.Parse(v[4]) ? (byte)1 : (byte)0 };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FBox2f value, JsonSerializerOptions options)
        {
            string s = $"{value.Min.X} {value.Min.Y} {value.Max.X} {value.Max.Y} {value.IsValid == 1}";
            writer.WriteStringValue(s);
        }
    }
    #endregion
}
