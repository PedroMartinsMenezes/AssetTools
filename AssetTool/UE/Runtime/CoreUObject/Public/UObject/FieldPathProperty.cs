using System.Text.Json;

namespace AssetTool
{
    public class FFieldPathProperty : FProperty
    {
        public new const string TYPE_NAME = "FieldPathProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 InOwner;
        public FName InName;
        public UInt32 InObjectFlags;
        public FFieldPath FieldPtr;

        public override FField Move(Transfer transfer)
        {
            transfer.Move(ref InOwner);
            transfer.Move(ref InName);
            transfer.Move(ref InObjectFlags);
            return this;
        }

        [Location("void FFieldPathProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
        public FField SerializeItem(Transfer transfer)
        {
            transfer.Move(ref FieldPtr);
            return this;
        }

        public override FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            string key = elem.Name;

            JsonElement value = elem.Value;

            var obj = ReadKeyValue<FFieldPathProperty>(key, value);

            obj.InOwner = key.GetNonNull("InOwner({0})", x => uint.Parse(x), (uint)0);
            obj.InName = key.GetNonNull("InName({0})", x => new FName(x), new FName("None"));
            obj.InObjectFlags = key.GetNonNull("InObjectFlags({0})", x => uint.Parse(x), (uint)0);

            if (value.TryGetProperty("FieldPtr", out var fieldPtr))
            {
                obj.FieldPtr = JsonSerializer.Deserialize<FFieldPath>(fieldPtr.GetRawText(), options);
            }

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            Dictionary<string, object> inlineFields = new()
            {
                ["InOwner"] = this.InOwner,
                ["InName"] = this.InName,
                ["InObjectFlags"] = this.InObjectFlags
            };

            Dictionary<string, object> fields = null;
            if (this.FieldPtr is { })
            {
                fields = new()
                {
                    ["FieldPtr"] = this.FieldPtr
                };
            }

            WriteKeyValue(writer, options, this, "prop-fieldpath", inlineFields, fields);
        }
    }
}
