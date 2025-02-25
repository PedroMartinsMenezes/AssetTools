﻿using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    [TransferibleStruct("Guid")]
    public class FGuid : ITransferible
    {
        public const string TYPE_NAME = "Guid";

        public Guid Value;

        public FGuid() { }

        public FGuid(Guid value)
        {
            Value = value;
        }

        public FGuid(string value)
        {
            Value = new Guid(value);
        }

        public FGuid(byte[] bytes)
        {
            (byte b4, byte b5, byte b6, byte b7) = (bytes[4], bytes[5], bytes[6], bytes[7]);
            (bytes[4], bytes[5], bytes[6], bytes[7]) = (b6, b7, b4, b5);

            (byte b8, byte b9, byte b10, byte b11) = (bytes[8], bytes[9], bytes[10], bytes[11]);
            (bytes[8], bytes[9], bytes[10], bytes[11]) = (b11, b10, b9, b8);

            (byte b12, byte b13, byte b14, byte b15) = (bytes[12], bytes[13], bytes[14], bytes[15]);
            (bytes[12], bytes[13], bytes[14], bytes[15]) = (b15, b14, b13, b12);

            Value = new Guid(bytes);
        }

        public byte[] ToByteArray()
        {
            var bytes = Value.ToByteArray();
            (byte b4, byte b5, byte b6, byte b7) = (bytes[4], bytes[5], bytes[6], bytes[7]);
            (bytes[4], bytes[5], bytes[6], bytes[7]) = (b6, b7, b4, b5);
            (byte b8, byte b9, byte b10, byte b11) = (bytes[8], bytes[9], bytes[10], bytes[11]);
            (bytes[8], bytes[9], bytes[10], bytes[11]) = (b11, b10, b9, b8);
            (byte b12, byte b13, byte b14, byte b15) = (bytes[12], bytes[13], bytes[14], bytes[15]);
            (bytes[12], bytes[13], bytes[14], bytes[15]) = (b15, b14, b13, b12);
            return bytes;
        }

        public ITransferible Move(Transfer transfer)
        {
            return transfer.Move(this);
        }

        public static FGuid MoveValue(Transfer transfer, FGuid value)
        {
            transfer.Move(ref value);
            return value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public static class FGuidExt
    {
        public static FGuid Write(this BinaryWriter writer, FGuid guid)
        {
            byte[] bytes = guid is { } ? guid.ToByteArray() : new byte[16];
            writer.Write(bytes);
            return guid;
        }

        public static FGuid Read(this BinaryReader reader, ref FGuid item)
        {
            byte[] bytes = reader.ReadBytes(16);
            return item = Array.Exists(bytes, x => x > 0) ? new FGuid(bytes) : null;
        }

        public static FGuid ReadFGuid(this BinaryReader reader)
        {
            byte[] bytes = reader.ReadBytes(16);
            return Array.Exists(bytes, x => x > 0) ? new FGuid(bytes) : null;
        }

        public static void WriteFGuid(this BinaryWriter writer, object value)
        {
            byte[] bytes = value is { } ? new FGuid(value.ToString()).ToByteArray() : new byte[16];
            writer.Write(bytes);
        }
    }

    public class FGuidJsonConverter : JsonConverter<FGuid>
    {
        public override FGuid Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FGuid(reader.GetString()!);
        }

        public override FGuid ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }

        public override void Write(Utf8JsonWriter writer, FGuid value, JsonSerializerOptions options)
        {
            string text = value.ToString();
            writer.WriteStringValue(text);
        }

        public override void WriteAsPropertyName(Utf8JsonWriter writer, FGuid value, JsonSerializerOptions options)
        {
            string text = value.ToString();
            writer.WritePropertyName(text);
        }
    }
}
