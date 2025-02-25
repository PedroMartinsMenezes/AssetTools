﻿using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Value}")]
    public class FBool : ITransferible
    {
        public FBool() { }

        public FBool(string v) { Value = bool.Parse(v); }

        public FBool(int v) { Value = v == 1; }

        public FBool(bool v) { Value = v; }

        public bool Value;

        public override string ToString()
        {
            return Value.ToString();
        }

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(this);
            return this;
        }

        public static implicit operator bool(FBool self)
        {
            return self?.Value == true;
        }
    }

    public class FBoolJsonConverter : JsonConverter<FBool>
    {
        public override FBool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FBool { Value = bool.Parse(reader.GetString()) };
        }
        public override void Write(Utf8JsonWriter writer, FBool value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Value.ToString());
        }
    }
}
