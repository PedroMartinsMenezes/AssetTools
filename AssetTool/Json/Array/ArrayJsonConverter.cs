using System.Text.Json.Serialization;
using System.Text.Json;
using System.Globalization;

namespace AssetTool
{
    public class Int16ArrayJsonConverter : JsonConverter<Int16[]>
    {
        public override Int16[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string str = reader.GetString();
            return str.Length == 0 ? new Int16[0] : str.Split(' ').Select(x => Int16.Parse(x)).ToArray();
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
            string str = reader.GetString();
            return str.Length == 0 ? new UInt16[0] : str.Split(' ').Select(x => UInt16.Parse(x)).ToArray();
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
            string str = reader.GetString();
            return str.Length == 0 ? new Int32[0] : str.Split(' ').Select(x => Int32.Parse(x)).ToArray();
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
            string str = reader.GetString();
            return str.Length == 0 ? new UInt32[0] : str.Split(' ').Select(x => UInt32.Parse(x)).ToArray();
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
            string str = reader.GetString();
            return str.Length == 0 ? new Int64[0] : str.Split(' ').Select(x => Int64.Parse(x)).ToArray();
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
            string str = reader.GetString();
            return str.Length == 0 ? new UInt64[0] : str.Split(' ').Select(x => UInt64.Parse(x)).ToArray();
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
            string str = reader.GetString();
            return str.Length == 0 ? new float[0] : str.Split(' ').Select(x => float.Parse(x, CultureInfo.InvariantCulture)).ToArray();
        }
        public override void Write(Utf8JsonWriter writer, float[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }

    public class DoubleArrayJsonConverter : JsonConverter<double[]>
    {
        public override double[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string str = reader.GetString();
            return str.Length == 0 ? new double[0] : str.Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
        }
        public override void Write(Utf8JsonWriter writer, double[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }
}
