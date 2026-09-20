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

        public override FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            string key = elem.Name;
            JsonElement value = elem.Value;
            var obj = ReadKeyValue<FArrayProperty>(key, value);
            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x));
            obj.PropertyTypeName = key.GetNonNull("PropertyTypeName({0})", x => new FName(x));
            if (value.TryGetProperty("SingleField", out var singleField))
            {
                obj.SingleField = JsonSerializer.Deserialize<FField>(singleField.GetRawText(), options);
            }
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            Dictionary<string, object> inlineFields = new()
            {
                ["ElementSize"] = this.ElementSize,
                ["PropertyTypeName"] = this.PropertyTypeName
            };
            Dictionary<string, object> fields = null;
            if (this.SingleField is { })
            {
                fields = new()
                {
                    ["SingleField"] = this.SingleField,
                };
            }
            WriteKeyValue(writer, options, this, "prop-array", inlineFields, fields);
        }
    }
}
