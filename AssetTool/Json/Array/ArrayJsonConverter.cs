using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class SByteArrayJsonConverter : JsonConverter<sbyte[]>
    {
        public override sbyte[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToSByteArray();
        }
        public override void Write(Utf8JsonWriter writer, sbyte[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }

    public class SByteListJsonConverter : JsonConverter<List<sbyte>>
    {
        public override List<sbyte> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToSByteArray().ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<sbyte> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }

    public class BoolArrayJsonConverter : JsonConverter<bool[]>
    {
        public override bool[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToBoolArray();
        }
        public override void Write(Utf8JsonWriter writer, bool[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }

    public class BoolListJsonConverter : JsonConverter<List<bool>>
    {
        public override List<bool> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToBoolArray().ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<bool> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }

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

    public class Int16ListJsonConverter : JsonConverter<List<Int16>>
    {
        public override List<Int16> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToInt16Array().ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<Int16> value, JsonSerializerOptions options)
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

    public class UInt16ListJsonConverter : JsonConverter<List<UInt16>>
    {
        public override List<UInt16> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToUInt16Array().ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<UInt16> value, JsonSerializerOptions options)
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

    public class Int32ListJsonConverter : JsonConverter<List<Int32>>
    {
        public override List<Int32> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToInt32Array().ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<Int32> value, JsonSerializerOptions options)
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

    public class UInt32ListJsonConverter : JsonConverter<List<UInt32>>
    {
        public override List<UInt32> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToUInt32Array().ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<UInt32> value, JsonSerializerOptions options)
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

    public class Int64ListJsonConverter : JsonConverter<List<Int64>>
    {
        public override List<Int64> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToInt64Array().ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<Int64> value, JsonSerializerOptions options)
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

    public class UInt64ListJsonConverter : JsonConverter<List<UInt64>>
    {
        public override List<UInt64> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToUInt64Array().ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<UInt64> value, JsonSerializerOptions options)
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
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            writer.WriteStringValue(string.Join(' ', value));
        }
    }

    public class FloatListJsonConverter : JsonConverter<List<float>>
    {
        public override List<float> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToFloatArray().ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<float> value, JsonSerializerOptions options)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
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
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            writer.WriteStringValue(string.Join(' ', value));
        }
    }

    public class DoubleListJsonConverter : JsonConverter<List<double>>
    {
        public override List<double> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().ToDoubleArray().ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<double> value, JsonSerializerOptions options)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            writer.WriteStringValue(string.Join(' ', value));
        }
    }
}
