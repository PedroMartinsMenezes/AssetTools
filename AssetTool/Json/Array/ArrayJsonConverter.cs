using System.Text.Json.Serialization;
using System.Text.Json;

namespace AssetTool
{
    public class Int16ArrayJsonConverter : JsonConverter<Int16[]>
    {
        public override Int16[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToInt16Array();
        }
        public override void Write(Utf8JsonWriter writer, Int16[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }

    public class UInt16ArrayJsonConverter : JsonConverter<UInt16[]>
    {
        public override UInt16[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToUInt16Array();
        }
        public override void Write(Utf8JsonWriter writer, UInt16[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }

    public class Int32ArrayJsonConverter : JsonConverter<Int32[]>
    {
        public override Int32[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToInt32Array();
        }
        public override void Write(Utf8JsonWriter writer, Int32[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }

    public class UInt32ArrayJsonConverter : JsonConverter<UInt32[]>
    {
        public override UInt32[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToUInt32Array();
        }
        public override void Write(Utf8JsonWriter writer, UInt32[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }

    public class Int64ArrayJsonConverter : JsonConverter<Int64[]>
    {
        public override Int64[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToInt64Array();
        }
        public override void Write(Utf8JsonWriter writer, Int64[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }

    public class UInt64ArrayJsonConverter : JsonConverter<UInt64[]>
    {
        public override UInt64[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToUInt64Array();
        }
        public override void Write(Utf8JsonWriter writer, UInt64[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }

    public class FloatArrayJsonConverter : JsonConverter<float[]>
    {
        public override float[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToFloatArray();
        }
        public override void Write(Utf8JsonWriter writer, float[] value, JsonSerializerOptions options)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            writer.WriteStringValue(string.Join(' ', value));
        }
    }

    public class DoubleArrayJsonConverter : JsonConverter<double[]>
    {
        public override double[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToDoubleArray();
        }
        public override void Write(Utf8JsonWriter writer, double[] value, JsonSerializerOptions options)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            writer.WriteStringValue(string.Join(' ', value));
        }
    }
}
