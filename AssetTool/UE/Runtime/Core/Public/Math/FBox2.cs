using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    #region Double
    [TransferibleStruct("Box2d", "Box2D", 33)]
    public class FBox2d : ITransferible, ITagConverter
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

        public object DerivedToTag(object elem, Transfer transfer)
        {
            return elem.ToObject<FBox2d>(transfer);
        }
    }
    public class FBox2dJsonConverter : JsonConverter<FBox2d>
    {
        public override FBox2d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FBox2d { Min = new() { X = v[0], Y = v[1] }, Max = new() { X = v[2], Y = v[3] }, IsValid = v[4] > 0 ? (byte)1 : (byte)0 };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FBox2d value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.Min.X} {value.Min.Y} {value.Max.X} {value.Max.Y} {(double)value.IsValid}");
            writer.WriteStringValue(s);
        }
    }
    #endregion

    #region Float
    [TransferibleStruct("Box2f", "Box2D", 17)]
    public class FBox2f : ITransferible, ITagConverter
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

        #region ITagConverter
        public object DerivedToTag(object elem, Transfer transfer)
        {
            return elem.ToObject<FBox2f>(transfer);
        }
        #endregion
    }
    public class FBox2fJsonConverter : JsonConverter<FBox2f>
    {
        public override FBox2f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FBox2f { Min = new() { X = v[0], Y = v[1] }, Max = new() { X = v[2], Y = v[3] }, IsValid = v[4] > 0 ? (byte)1 : (byte)0 };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FBox2f value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.Min.X} {value.Min.Y} {value.Max.X} {value.Max.Y} {(float)value.IsValid}");
            writer.WriteStringValue(s);
        }
    }
    #endregion

    #region Float or Double
    [TransferibleStruct("Box2D", size1: 17, size2: 33)]
    public class FBox2D : ITransferible, ITagConverter
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
        #region ITagConverter
        public object DerivedToTag(object elem, Transfer transfer)
        {
            return elem.ToObject<FBox2D>(transfer);
        }
        #endregion
    }
    public class FBox2DJsonConverter : JsonConverter<FBox2D>
    {
        public override FBox2D Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var obj = new FBox2D { Min = new() { X = v[0], Y = v[1] }, Max = new() { X = v[2], Y = v[3] }, IsValid = v[4] > 0 ? (byte)1 : (byte)0 };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, FBox2D value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Create(CultureInfo.InvariantCulture, $"{value.Min.X} {value.Min.Y} {value.Max.X} {value.Max.Y} {(double)value.IsValid}"));
        }
    }
    #endregion
}
