using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    public class TInt8 : ITransferible
    {
        public sbyte Value;
        public override string ToString() => Value.ToString();

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
    public class TInt8JsonConverter : JsonConverter<TInt8>
    {
        public override TInt8 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var obj = new TInt8 { Value = reader.GetSByte() };
            return obj;
        }
        public override TInt8 ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new TInt8 { Value = sbyte.Parse(reader.GetString()) };
        }
        public override void Write(Utf8JsonWriter writer, TInt8 value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.Value);
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, TInt8 value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.Value.ToString());
        }
    }

    [DebuggerDisplay("{Value}")]
    public class TInt16 : ITransferible
    {
        public Int16 Value;
        public override string ToString() => Value.ToString();

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
    public class TInt16JsonConverter : JsonConverter<TInt16>
    {
        public override TInt16 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var obj = new TInt16 { Value = reader.GetInt16() };
            return obj;
        }
        public override TInt16 ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new TInt16 { Value = Int16.Parse(reader.GetString()) };
        }
        public override void Write(Utf8JsonWriter writer, TInt16 value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.Value);
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, TInt16 value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.Value.ToString());
        }
    }

    [DebuggerDisplay("{Value}")]
    public class TInt32 : ITransferible
    {
        public Int32 Value;
        public override string ToString() => Value.ToString();

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
    public class TInt32JsonConverter : JsonConverter<TInt32>
    {
        public override TInt32 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new TInt32 { Value = reader.GetInt32() };
        }
        public override TInt32 ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new TInt32 { Value = Int32.Parse(reader.GetString()) };
        }
        public override void Write(Utf8JsonWriter writer, TInt32 value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.Value);
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, TInt32 value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.Value.ToString());
        }
    }

    [DebuggerDisplay("{Value}")]
    public class TInt64 : ITransferible
    {
        public Int64 Value;
        public override string ToString() => Value.ToString();

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
    public class TInt64JsonConverter : JsonConverter<TInt64>
    {
        public override TInt64 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var obj = new TInt64 { Value = reader.GetInt64() };
            return obj;
        }
        public override TInt64 ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new TInt64 { Value = Int64.Parse(reader.GetString()) };
        }
        public override void Write(Utf8JsonWriter writer, TInt64 value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.Value);
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, TInt64 value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.Value.ToString());
        }
    }

    [DebuggerDisplay("{Value}")]
    public class TUInt8 : ITransferible
    {
        public byte Value;
        public override string ToString() => Value.ToString();

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
    public class TUInt8JsonConverter : JsonConverter<TUInt8>
    {
        public override TUInt8 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var obj = new TUInt8 { Value = reader.GetByte() };
            return obj;
        }
        public override TUInt8 ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new TUInt8 { Value = byte.Parse(reader.GetString()) };
        }
        public override void Write(Utf8JsonWriter writer, TUInt8 value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.Value);
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, TUInt8 value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.Value.ToString());
        }
    }
    public class TUInt8ArrayJsonConverter : JsonConverter<TUInt8[]>
    {
        public override TUInt8[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(' ').Select(x => new TUInt8 { Value = byte.Parse(x) }).ToArray();
        }
        public override void Write(Utf8JsonWriter writer, TUInt8[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }

    [DebuggerDisplay("{Value}")]
    public class TUInt16 : ITransferible
    {
        public UInt16 Value;
        public override string ToString() => Value.ToString();

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
    public class TUInt16JsonConverter : JsonConverter<TUInt16>
    {
        public override TUInt16 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var obj = new TUInt16 { Value = reader.GetUInt16() };
            return obj;
        }
        public override TUInt16 ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new TUInt16 { Value = UInt16.Parse(reader.GetString()) };
        }
        public override void Write(Utf8JsonWriter writer, TUInt16 value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.Value);
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, TUInt16 value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.Value.ToString());
        }
    }

    [DebuggerDisplay("{Value}")]
    public class TUInt32 : ITransferible
    {
        public UInt32 Value;
        public override string ToString() => Value.ToString();

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
    public class TUInt32JsonConverter : JsonConverter<TUInt32>
    {
        public override TUInt32 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var obj = new TUInt32 { Value = reader.GetUInt32() };
            return obj;
        }
        public override TUInt32 ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new TUInt32 { Value = UInt32.Parse(reader.GetString()) };
        }
        public override void Write(Utf8JsonWriter writer, TUInt32 value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.Value);
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, TUInt32 value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.Value.ToString());
        }
    }

    [DebuggerDisplay("{Value}")]
    public class TUInt64 : ITransferible
    {
        public UInt64 Value;
        public override string ToString() => Value.ToString();

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
    public class TUInt64JsonConverter : JsonConverter<TUInt64>
    {
        public override TUInt64 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var obj = new TUInt64 { Value = reader.GetUInt64() };
            return obj;
        }
        public override TUInt64 ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new TUInt64 { Value = UInt64.Parse(reader.GetString()) };
        }
        public override void Write(Utf8JsonWriter writer, TUInt64 value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.Value);
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, TUInt64 value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.Value.ToString());
        }
    }

    [DebuggerDisplay("{Value}")]
    public class TFloat : ITransferible
    {
        public float Value;
        public override string ToString() => Value.ToString();

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
    public class TFloatJsonConverter : JsonConverter<TFloat>
    {
        public override TFloat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var obj = new TFloat { Value = reader.GetSingle() };
            return obj;
        }
        public override TFloat ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new TFloat { Value = float.Parse(reader.GetString()) };
        }
        public override void Write(Utf8JsonWriter writer, TFloat value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.Value);
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, TFloat value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.Value.ToString());
        }
    }

    [DebuggerDisplay("{Value}")]
    public class TDouble : ITransferible
    {
        public double Value;
        public override string ToString() => Value.ToString();

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
    public class TDoubleJsonConverter : JsonConverter<TDouble>
    {
        public override TDouble Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var obj = new TDouble { Value = reader.GetDouble() };
            return obj;
        }
        public override TDouble ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new TDouble { Value = double.Parse(reader.GetString()) };
        }
        public override void Write(Utf8JsonWriter writer, TDouble value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.Value);
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, TDouble value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.Value.ToString());
        }
    }
}
