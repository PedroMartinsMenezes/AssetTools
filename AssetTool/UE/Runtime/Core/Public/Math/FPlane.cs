using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [TransferibleStruct("Plane4d", "Plane", 32)]
    [DebuggerDisplay("({X} {Y} {Z} {W})")]
    public struct FPlane4d : ITransferible, ITagConverter
    {
        public double X;
        public double Y;
        public double Z;
        public double W;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }

        public object DerivedToTag(object elem, Transfer transfer)
        {
            return elem.ToObject<FPlane4d>(transfer);
        }
    }

    public class FPlane4dJsonConverter : JsonConverter<FPlane4d>
    {
        public override FPlane4d Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToDoubleArray();
            return new FPlane4d { X = v[0], Y = v[1], Z = v[2], W = v[3] };
        }

        public override void Write(Utf8JsonWriter writer, FPlane4d value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z} {value.W}");
            writer.WriteStringValue(s);
        }
    }

    [TransferibleStruct("Plane4f", "Plane", 16)]
    [DebuggerDisplay("({X} {Y} {Z} {W})")]
    public struct FPlane4f : ITransferible, ITagConverter
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }

        public object DerivedToTag(object elem, Transfer transfer)
        {
            return elem.ToObject<FPlane4f>(transfer);
        }
    }

    public class FPlane4fJsonConverter : JsonConverter<FPlane4f>
    {
        public override FPlane4f Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToFloatArray();
            return new FPlane4f { X = v[0], Y = v[1], Z = v[2], W = v[3] };
        }

        public override void Write(Utf8JsonWriter writer, FPlane4f value, JsonSerializerOptions options)
        {
            string s = string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z} {value.W}");
            writer.WriteStringValue(s);
        }
    }

    [TransferibleStruct("Plane", size1: 16, size2: 32)]
    [DebuggerDisplay("({X} {Y} {Z} {W})")]
    public struct FPlane : ITransferible, ITagConverter
    {
        public double X;
        public double Y;
        public double Z;
        public double W;

        public ITransferible Move(Transfer transfer)
        {
            transfer.MoveSingleOrDouble(ref X);
            transfer.MoveSingleOrDouble(ref Y);
            transfer.MoveSingleOrDouble(ref Z);
            transfer.MoveSingleOrDouble(ref W);
            return this;
        }

        public object DerivedToTag(object elem, Transfer transfer)
        {
            return elem.ToObject<FPlane>(transfer);
        }
    }

    public class FPlaneJsonConverter : JsonConverter<FPlane>
    {
        public Transfer transfer;

        public FPlaneJsonConverter SetTransfer(Transfer transfer)
        {
            this.transfer = transfer;
            return this;
        }

        public override FPlane Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToDoubleArray();
            return new FPlane { X = v[0], Y = v[1], Z = v[2], W = v[3] };
        }

        public override void Write(Utf8JsonWriter writer, FPlane value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Create(CultureInfo.InvariantCulture, $"{value.X} {value.Y} {value.Z} {value.W}"));
        }
    }
}
