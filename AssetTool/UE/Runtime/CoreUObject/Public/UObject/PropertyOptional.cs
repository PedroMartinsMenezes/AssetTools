using System.Text.Json;

namespace AssetTool
{
    public class FOptionalProperty : FProperty
    {
        public new const string TYPE_NAME = "OptionalProperty";
        public override string TypeName => TYPE_NAME;

        public FName PropertyTypeName;
        public FField SingleField;

        public UInt32 Value;
        public byte BoolProperty;

        [Location("void FOptionalProperty::Serialize(FArchive& Ar)")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            FField.SerializeSingleField(transfer, ref PropertyTypeName, ref SingleField);
            return this;
        }

        public FField MoveValue(Transfer transfer, string innerType, int size)
        {
            transfer.Move(ref Value);
            if (size > 4)
            {
                if (innerType == FBoolProperty.TYPE_NAME)
                {
                    transfer.Move(ref BoolProperty);
                }
            }
            return this;
        }

        public override FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            string key = elem.Name;

            JsonElement value = elem.Value;

            var obj = ReadKeyValue<FOptionalProperty>(key, value);

            obj.ElementSize = key.GetNonNull("ElementSize({0})", x => int.Parse(x), 0);
            obj.PropertyTypeName = key.GetNonNull("PropertyTypeName({0})", x => new FName(x));
            obj.Value = key.GetNonNull("Value({0})", x => uint.Parse(x), (uint)0);
            obj.BoolProperty = key.GetNonNull("BoolProperty({0})", x => byte.Parse(x), (byte)0);

            if (value.ValueKind == JsonValueKind.Object && value.TryGetProperty("SingleField", out var singleField))
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
                ["PropertyTypeName"] = this.PropertyTypeName,
                ["Value"] = this.Value,
                ["BoolProperty"] = this.BoolProperty
            };

            Dictionary<string, object> fields = null;
            if (this.SingleField is { })
            {
                fields = new()
                {
                    ["SingleField"] = this.SingleField
                };
            }

            WriteKeyValue(writer, options, this, "prop-optional", inlineFields, fields);
        }
    }
}
