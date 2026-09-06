using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    #region FIntVector2
    [TransferableStruct("IntVector2")]
    [DebuggerDisplay("({X} {Y})")]
    public class FIntVector2 : ITransferable
    {
        public Int32 X;
        public Int32 Y;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
    }

    public class FIntVector2ListJsonConverter : JsonConverter<List<FIntVector2>>
    {
        public override List<FIntVector2> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(" | ").Select(x => x.Split(' ') is var v ? new FIntVector2 { X = int.Parse(v[0]), Y = int.Parse(v[1]) } : default).ToList();
        }

        public override void Write(Utf8JsonWriter writer, List<FIntVector2> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.X} {x.Y}")));
        }
    }
    #endregion

    #region FIntVector3
    [TransferableStruct("IntVector")]
    [DebuggerDisplay("({X} {Y} {Z})")]
    public class FIntVector3 : ITransferable
    {
        public Int32 X;
        public Int32 Y;
        public Int32 Z;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
    }

    public class FIntVector3ListJsonConverter : JsonConverter<List<FIntVector3>>
    {
        public override List<FIntVector3> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(" | ").Select(x => x.Split(' ') is var v ? new FIntVector3 { X = int.Parse(v[0]), Y = int.Parse(v[1]), Z = int.Parse(v[2]) } : default).ToList();
        }

        public override void Write(Utf8JsonWriter writer, List<FIntVector3> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.X} {x.Y} {x.Z}")));
        }
    }
    #endregion

    #region FIntVector4
    [TransferableStruct("IntVector4")]
    [DebuggerDisplay("({X} {Y} {Z} {W})")]
    public class FIntVector4 : ITransferable
    {
        public Int32 X;
        public Int32 Y;
        public Int32 Z;
        public Int32 W;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
    }

    public class FIntVector4ListJsonConverter : JsonConverter<List<FIntVector4>>
    {
        public override List<FIntVector4> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(" | ").Select(x => x.Split(' ') is var v ? new FIntVector4 { X = int.Parse(v[0]), Y = int.Parse(v[1]), Z = int.Parse(v[2]), W = int.Parse(v[3]) } : default).ToList();
        }

        public override void Write(Utf8JsonWriter writer, List<FIntVector4> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.X} {x.Y} {x.Z} {x.W}")));
        }
    }
    #endregion

    #region FUIntVector2
    [TransferableStruct("UIntVector2")]
    [DebuggerDisplay("({X} {Y})")]
    public class FUIntVector2 : ITransferable
    {
        public UInt32 X;
        public UInt32 Y;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
    }

    public class FUIntVector2ListJsonConverter : JsonConverter<List<FUIntVector2>>
    {
        public override List<FUIntVector2> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(" | ").Select(x => x.Split(' ') is var v ? new FUIntVector2 { X = uint.Parse(v[0]), Y = uint.Parse(v[1]) } : default).ToList();
        }

        public override void Write(Utf8JsonWriter writer, List<FUIntVector2> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.X} {x.Y}")));
        }
    }
    #endregion

    #region FUIntVector3
    [TransferableStruct("UIntVector")]
    [DebuggerDisplay("({X} {Y} {Z})")]
    public class FUIntVector3 : ITransferable
    {
        public UInt32 X;
        public UInt32 Y;
        public UInt32 Z;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
    }

    public class FUIntVector3ListJsonConverter : JsonConverter<List<FUIntVector3>>
    {
        public override List<FUIntVector3> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(" | ").Select(x => x.Split(' ') is var v ? new FUIntVector3 { X = uint.Parse(v[0]), Y = uint.Parse(v[1]), Z = uint.Parse(v[2]) } : default).ToList();
        }

        public override void Write(Utf8JsonWriter writer, List<FUIntVector3> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.X} {x.Y} {x.Z}")));
        }
    }
    #endregion

    #region FUIntVector4
    [TransferableStruct("UIntVector4")]
    [DebuggerDisplay("({X} {Y} {Z} {W})")]
    public class FUIntVector4 : ITransferable
    {
        public UInt32 X;
        public UInt32 Y;
        public UInt32 Z;
        public UInt32 W;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
    }

    public class FUIntVector4ListJsonConverter : JsonConverter<List<FUIntVector4>>
    {
        public override List<FUIntVector4> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(" | ").Select(x => x.Split(' ') is var v ? new FUIntVector4 { X = uint.Parse(v[0]), Y = uint.Parse(v[1]), Z = uint.Parse(v[2]), W = uint.Parse(v[3]) } : default).ToList();
        }

        public override void Write(Utf8JsonWriter writer, List<FUIntVector4> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.X} {x.Y} {x.Z} {x.W}")));
        }
    }
    #endregion

    #region FInt64Vector2
    [TransferableStruct("Int64Vector2")]
    [DebuggerDisplay("({X} {Y})")]
    public class FInt64Vector2 : ITransferable
    {
        public Int64 X;
        public Int64 Y;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
    }

    public class FInt64Vector2ListJsonConverter : JsonConverter<List<FInt64Vector2>>
    {
        public override List<FInt64Vector2> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(" | ").Select(x => x.Split(' ') is var v ? new FInt64Vector2 { X = long.Parse(v[0]), Y = long.Parse(v[1]) } : default).ToList();
        }

        public override void Write(Utf8JsonWriter writer, List<FInt64Vector2> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.X} {x.Y}")));
        }
    }
    #endregion

    #region FInt64Vector3
    [TransferableStruct("Int64Vector")]
    [DebuggerDisplay("({X} {Y} {Z})")]
    public class FInt64Vector3 : ITransferable
    {
        public Int64 X;
        public Int64 Y;
        public Int64 Z;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
    }

    public class FInt64Vector3ListJsonConverter : JsonConverter<List<FInt64Vector3>>
    {
        public override List<FInt64Vector3> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(" | ").Select(x => x.Split(' ') is var v ? new FInt64Vector3 { X = long.Parse(v[0]), Y = long.Parse(v[1]), Z = long.Parse(v[2]) } : default).ToList();
        }

        public override void Write(Utf8JsonWriter writer, List<FInt64Vector3> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.X} {x.Y} {x.Z}")));
        }
    }
    #endregion

    #region FInt64Vector4
    [TransferableStruct("Int64Vector4")]
    [DebuggerDisplay("({X} {Y} {Z} {W})")]
    public class FInt64Vector4 : ITransferable
    {
        public Int64 X;
        public Int64 Y;
        public Int64 Z;
        public Int64 W;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
    }

    public class FInt64Vector4ListJsonConverter : JsonConverter<List<FInt64Vector4>>
    {
        public override List<FInt64Vector4> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(" | ").Select(x => x.Split(' ') is var v ? new FInt64Vector4 { X = long.Parse(v[0]), Y = long.Parse(v[1]), Z = long.Parse(v[2]), W = long.Parse(v[3]) } : default).ToList();
        }

        public override void Write(Utf8JsonWriter writer, List<FInt64Vector4> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.X} {x.Y} {x.Z} {x.W}")));
        }
    }
    #endregion

    #region FUInt64Vector2
    [TransferableStruct("UInt64Vector2")]
    [DebuggerDisplay("({X} {Y})")]
    public class FUInt64Vector2 : ITransferable
    {
        public UInt64 X;
        public UInt64 Y;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            return this;
        }
    }

    public class FUInt64Vector2ListJsonConverter : JsonConverter<List<FUInt64Vector2>>
    {
        public override List<FUInt64Vector2> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(" | ").Select(x => x.Split(' ') is var v ? new FUInt64Vector2 { X = ulong.Parse(v[0]), Y = ulong.Parse(v[1]) } : default).ToList();
        }

        public override void Write(Utf8JsonWriter writer, List<FUInt64Vector2> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.X} {x.Y}")));
        }
    }
    #endregion

    #region FUInt64Vector3
    [TransferableStruct("UInt64Vector")]
    [DebuggerDisplay("({X} {Y} {Z})")]
    public class FUInt64Vector3 : ITransferable
    {
        public UInt64 X;
        public UInt64 Y;
        public UInt64 Z;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
    }

    public class FUInt64Vector3ListJsonConverter : JsonConverter<List<FUInt64Vector3>>
    {
        public override List<FUInt64Vector3> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(" | ").Select(x => x.Split(' ') is var v ? new FUInt64Vector3 { X = ulong.Parse(v[0]), Y = ulong.Parse(v[1]), Z = ulong.Parse(v[2]) } : default).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<FUInt64Vector3> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.X} {x.Y} {x.Z}")));
        }
    }
    #endregion

    #region FUInt64Vector4
    [TransferableStruct("UInt64Vector4")]
    [DebuggerDisplay("({X} {Y} {Z} {W})")]
    public class FUInt64Vector4 : ITransferable
    {
        public UInt64 X;
        public UInt64 Y;
        public UInt64 Z;
        public UInt64 W;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }
    }

    public class FUInt64Vector4ListJsonConverter : JsonConverter<List<FUInt64Vector4>>
    {
        public override List<FUInt64Vector4> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString().Split(" | ").Select(x => x.Split(' ') is var v ? new FUInt64Vector4 { X = ulong.Parse(v[0]), Y = ulong.Parse(v[1]), Z = ulong.Parse(v[2]), W = ulong.Parse(v[3]) } : default).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<FUInt64Vector4> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.X} {x.Y} {x.Z} {x.W}")));
        }
    }
    #endregion
}
