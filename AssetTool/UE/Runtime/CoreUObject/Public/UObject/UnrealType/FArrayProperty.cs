using System.Diagnostics;
using System.Text.Json;

namespace AssetTool
{
    [DebuggerDisplay("{TypeName}<{PropertyTypeName}> {NamePrivate.ToString()}")]
    public class FArrayProperty : FProperty
    {
        public new const string TYPE_NAME = "ArrayProperty";
        public override string TypeName => TYPE_NAME;

        public FName PropertyTypeName;
        public FField SingleField;

        [Location("void FArrayProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            FField.SerializeSingleField(transfer, ref PropertyTypeName, ref SingleField);
            return this;
        }
    }

    public class FArrayPropertySerializer : FPropertySerializerBase<FArrayProperty>
    {
        public FArrayProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;
            JsonElement value = root.EnumerateObject().First().Value;
            var obj = ReadKeyValue(key, value);
            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x));
            obj.PropertyTypeName = key.GetNonNull("PropertyTypeName({0})", x => new FName(x));
            if (value.TryGetProperty("SingleField", out var singleField))
            {
                obj.SingleField = JsonSerializer.Deserialize<FField>(singleField.GetRawText(), options);
            }
            return obj;
        }

        public void Write(Utf8JsonWriter writer, FArrayProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = value.ElementSize,
                ["PropertyTypeName"] = value.PropertyTypeName
            };
            Dictionary<string, object> fields = null;
            if (value.SingleField is { })
            {
                fields = new()
                {
                    ["SingleField"] = value.SingleField,
                };
            }
            WriteKeyValue(writer, options, value, "prop-array", inlineFields, fields);
            writer.WriteEndObject();
        }
    }
}
