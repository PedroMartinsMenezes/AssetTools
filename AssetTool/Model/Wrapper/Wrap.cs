using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    #region TBulkList
    [DebuggerDisplay("ElementSize({ElementSize}) ElementCount({ElementCount})")]
    public class TBulkList<T> : ITransferable<bool> where T : ITransferable, new()
    {
        [JsonIgnore] public int Count => Items.Count;
        public int ElementSize;
        public int ElementCount;
        public List<T> Items;

        public ITransferable Move(Transfer transfer)
        {
            return Move(transfer, false);
        }

        public ITransferable Move(Transfer transfer, bool bForcePerElementSerialization)
        {
            if (bForcePerElementSerialization)
            {
                transfer.Move(ref Items);
                return this;
            }
            else
            {
                transfer.Move(ref ElementSize);
                if (ElementSize <= 0)
                    throw new InvalidOperationException();
                transfer.Move(ref ElementCount);
                transfer.Move(ref Items, ElementCount);
                return this;
            }
        }
    }

    public class TBulkListTUInt16JsonConverter : JsonConverter<TBulkList<TUInt16>>
    {
        public override TBulkList<TUInt16> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var parts = reader.GetString().Split(" | ");
            var header = parts[0].Split(' ');
            int elementSize = int.Parse(header[1]);
            int elementCount = int.Parse(header[3]);
            var items = parts[1].Length == 0 ? new List<TUInt16>() : parts[1].Split(' ').Select(x => new TUInt16 { Value = UInt16.Parse(x) }).ToList();
            return new TBulkList<TUInt16> { ElementSize = elementSize, ElementCount = elementCount, Items = items };
        }
        public override void Write(Utf8JsonWriter writer, TBulkList<TUInt16> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"ElementSize {value.ElementSize} ElementCount {value.ElementCount} | {string.Join(' ', value.Items.Select(x => x.Value))}");
        }
    }
    #endregion

    #region TList
    public class TList<T> : ITransferable where T : ITransferable, new()
    {
        public List<T> Items;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Items);
            return this;
        }
    }

    public class TListOfList<T> : ITransferable where T : ITransferable, new()
    {
        public List<TList<T>> Items;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Items);
            return this;
        }
    }
    #endregion

    #region TTuple
    [DebuggerDisplay("{Item1}, {Item2}")]
    public class TTuple<T1, T2> : ITransferable where T1 : ITransferable, new() where T2 : ITransferable, new()
    {
        public T1 Item1;
        public T2 Item2;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Item1);
            transfer.Move(ref Item2);
            return this;
        }
    }

    public class TTupleFNameFNameJsonConverter : JsonConverter<TTuple<FName, FName>>
    {
        public override TTuple<FName, FName> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string[] parts = reader.GetString().Split(' ');
            return new TTuple<FName, FName> { Item1 = new FName(parts[0]), Item2 = new FName(parts[1]) };
        }

        public override TTuple<FName, FName> ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }

        public override void Write(Utf8JsonWriter writer, TTuple<FName, FName> value, JsonSerializerOptions options)
        {
            string key = $"{value.Item1.ToString()} {value.Item2.ToString()}";
            writer.WriteStringValue(key);
        }

        public override void WriteAsPropertyName(Utf8JsonWriter writer, TTuple<FName, FName> value, JsonSerializerOptions options)
        {
            string key = $"{value.Item1.ToString()} {value.Item2.ToString()}";
            writer.WritePropertyName(key);
        }
    }
    #endregion

    #region TRef
    public class TRef : ITransferable
    {
        public Int32 ExportIndex;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ExportIndex);
            if (ExportIndex > transfer.GlobalObjects.ExportMap.Count)
            {
                throw new InvalidOperationException("Invalid Export Index");
            }
            return this;
        }

        public override string ToString() => ExportIndex.ToString();

        public static TRef FromString(string str) => new TRef { ExportIndex = Int32.Parse(str) };
    }

    public class TRefJsonConverter : JsonConverter<TRef>
    {
        public override TRef Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new TRef { ExportIndex = reader.GetInt32() };
        }
        public override TRef ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new TRef { ExportIndex = Int32.Parse(reader.GetString()) };
        }
        public override void Write(Utf8JsonWriter writer, TRef value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.ExportIndex);
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, TRef value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.ExportIndex.ToString());
        }
    }
    #endregion

    #region TBool
    [DebuggerDisplay("{Value}")]
    public class TBool : ITransferable
    {
        public bool Value;
        public override string ToString() => Value.ToString();

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Value);
            return this;
        }
    }
    public class TBoolJsonConverter : JsonConverter<TBool>
    {
        public override TBool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var obj = new TBool { Value = reader.GetBoolean() };
            return obj;
        }
        public override TBool ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new TBool { Value = bool.Parse(reader.GetString()) };
        }
        public override void Write(Utf8JsonWriter writer, TBool value, JsonSerializerOptions options)
        {
            writer.WriteBooleanValue(value.Value);
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, TBool value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.Value.ToString());
        }
    }
    public class TListBoolJsonConverter : JsonConverter<List<TBool>>
    {
        public override List<TBool> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(' ').Select(x => new TBool { Value = bool.Parse(x) }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<TBool> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
    public class TArrayBoolJsonConverter : JsonConverter<TBool[]>
    {
        public override TBool[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(' ').Select(x => new TBool { Value = bool.Parse(x) }).ToArray() : [];
        }
        public override void Write(Utf8JsonWriter writer, TBool[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
    #endregion

    #region TInt8
    [DebuggerDisplay("{Value}")]
    public class TInt8 : ITransferable
    {
        public sbyte Value;
        public override string ToString() => Value.ToString();

        public ITransferable Move(Transfer transfer)
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
    public class TListInt8JsonConverter : JsonConverter<List<TInt8>>
    {
        public override List<TInt8> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(' ').Select(x => new TInt8 { Value = sbyte.Parse(x) }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<TInt8> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }
    public class TArrayInt8JsonConverter : JsonConverter<TInt8[]>
    {
        public override TInt8[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(' ').Select(x => new TInt8 { Value = sbyte.Parse(x) }).ToArray() : [];
        }
        public override void Write(Utf8JsonWriter writer, TInt8[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
    #endregion

    #region TInt16
    [DebuggerDisplay("{Value}")]
    public class TInt16 : ITransferable
    {
        public Int16 Value;
        public override string ToString() => Value.ToString();

        public ITransferable Move(Transfer transfer)
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
    public class TListInt16JsonConverter : JsonConverter<List<TInt16>>
    {
        public override List<TInt16> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(' ').Select(x => new TInt16 { Value = Int16.Parse(x) }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<TInt16> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }
    public class TArrayInt16JsonConverter : JsonConverter<TInt16[]>
    {
        public override TInt16[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(' ').Select(x => new TInt16 { Value = Int16.Parse(x) }).ToArray() : [];
        }
        public override void Write(Utf8JsonWriter writer, TInt16[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
    #endregion

    #region TInt32
    [DebuggerDisplay("{Value}")]
    public class TInt32 : ITransferable
    {
        public Int32 Value;
        public override string ToString() => Value.ToString();

        public ITransferable Move(Transfer transfer)
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
    public class TListInt32JsonConverter : JsonConverter<List<TInt32>>
    {
        public override List<TInt32> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(' ').Select(x => new TInt32 { Value = Int32.Parse(x) }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<TInt32> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }
    public class TArrayInt32JsonConverter : JsonConverter<TInt32[]>
    {
        public override TInt32[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(' ').Select(x => new TInt32 { Value = Int32.Parse(x) }).ToArray() : [];
        }
        public override void Write(Utf8JsonWriter writer, TInt32[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
    #endregion

    #region TInt64
    [DebuggerDisplay("{Value}")]
    public class TInt64 : ITransferable
    {
        public Int64 Value;
        public override string ToString() => Value.ToString();

        public ITransferable Move(Transfer transfer)
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
    public class TListInt64JsonConverter : JsonConverter<List<TInt64>>
    {
        public override List<TInt64> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(' ').Select(x => new TInt64 { Value = Int64.Parse(x) }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<TInt64> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }
    public class TArrayInt64JsonConverter : JsonConverter<TInt64[]>
    {
        public override TInt64[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(' ').Select(x => new TInt64 { Value = Int64.Parse(x) }).ToArray() : [];
        }
        public override void Write(Utf8JsonWriter writer, TInt64[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
    #endregion

    #region TUInt8
    [DebuggerDisplay("{Value}")]
    public struct TUInt8 : ITransferable
    {
        public byte Value;
        public override string ToString() => Value.ToString();

        public ITransferable Move(Transfer transfer)
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
            return reader.GetString() is string s && s.Length > 0 ? s.Split(' ').Select(x => new TUInt8 { Value = byte.Parse(x) }).ToArray() : [];
        }
        public override void Write(Utf8JsonWriter writer, TUInt8[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
    public class TListUInt8JsonConverter : JsonConverter<List<TUInt8>>
    {
        public override List<TUInt8> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(' ').Select(x => new TUInt8 { Value = byte.Parse(x) }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<TUInt8> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value));
        }
    }
    #endregion

    #region TUInt16
    [DebuggerDisplay("{Value}")]
    public class TUInt16 : ITransferable
    {
        public UInt16 Value;
        public override string ToString() => Value.ToString();

        public ITransferable Move(Transfer transfer)
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
    public class TUInt16ArrayJsonConverter : JsonConverter<TUInt16[]>
    {
        public override TUInt16[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(' ').Select(x => new TUInt16 { Value = UInt16.Parse(x) }).ToArray() : [];
        }
        public override void Write(Utf8JsonWriter writer, TUInt16[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
    public class TListUInt16JsonConverter : JsonConverter<List<TUInt16>>
    {
        public override List<TUInt16> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(' ').Select(x => new TUInt16 { Value = UInt16.Parse(x) }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<TUInt16> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
    #endregion

    #region TUInt32
    [DebuggerDisplay("{Value}")]
    public class TUInt32 : ITransferable
    {
        public UInt32 Value;
        public override string ToString() => Value.ToString();

        public ITransferable Move(Transfer transfer)
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
    public class TListUInt32JsonConverter : JsonConverter<List<TUInt32>>
    {
        public override List<TUInt32> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(' ').Select(x => new TUInt32 { Value = UInt32.Parse(x) }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<TUInt32> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
    public class TArrayUInt32JsonConverter : JsonConverter<TUInt32[]>
    {
        public override TUInt32[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(' ').Select(x => new TUInt32 { Value = UInt32.Parse(x) }).ToArray() : [];
        }
        public override void Write(Utf8JsonWriter writer, TUInt32[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
    #endregion

    #region TUInt64
    [DebuggerDisplay("{Value}")]
    public class TUInt64 : ITransferable
    {
        public UInt64 Value;
        public override string ToString() => Value.ToString();

        public ITransferable Move(Transfer transfer)
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
    public class TListUInt64JsonConverter : JsonConverter<List<TUInt64>>
    {
        public override List<TUInt64> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(' ').Select(x => new TUInt64 { Value = UInt64.Parse(x) }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<TUInt64> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
    public class TArrayUInt64JsonConverter : JsonConverter<TUInt64[]>
    {
        public override TUInt64[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(' ').Select(x => new TUInt64 { Value = UInt64.Parse(x) }).ToArray() : [];
        }
        public override void Write(Utf8JsonWriter writer, TUInt64[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
    #endregion

    #region TFloat
    [DebuggerDisplay("{Value}")]
    public class TFloat : ITransferable
    {
        public float Value;
        public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);

        public ITransferable Move(Transfer transfer)
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
            return new TFloat { Value = float.Parse(reader.GetString(), CultureInfo.InvariantCulture) };
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
    public class TListFloatJsonConverter : JsonConverter<List<TFloat>>
    {
        public override List<TFloat> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(' ').Select(x => new TFloat { Value = float.Parse(x, CultureInfo.InvariantCulture) }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<TFloat> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
    public class TArrayFloatJsonConverter : JsonConverter<TFloat[]>
    {
        public override TFloat[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(' ').Select(x => new TFloat { Value = float.Parse(x, CultureInfo.InvariantCulture) }).ToArray() : [];
        }
        public override void Write(Utf8JsonWriter writer, TFloat[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
    #endregion

    #region TDouble
    [DebuggerDisplay("{Value}")]
    public class TDouble : ITransferable
    {
        public double Value;
        public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);

        public ITransferable Move(Transfer transfer)
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
            return new TDouble { Value = double.Parse(reader.GetString(), CultureInfo.InvariantCulture) };
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
    public class TListDoubleJsonConverter : JsonConverter<List<TDouble>>
    {
        public override List<TDouble> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(' ').Select(x => new TDouble { Value = double.Parse(x, CultureInfo.InvariantCulture) }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<TDouble> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
    public class TArrayDoubleJsonConverter : JsonConverter<TDouble[]>
    {
        public override TDouble[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() is string s && s.Length > 0 ? s.Split(' ').Select(x => new TDouble { Value = double.Parse(x, CultureInfo.InvariantCulture) }).ToArray() : [];
        }
        public override void Write(Utf8JsonWriter writer, TDouble[] value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.Select(x => x.Value)));
        }
    }
    #endregion
}
