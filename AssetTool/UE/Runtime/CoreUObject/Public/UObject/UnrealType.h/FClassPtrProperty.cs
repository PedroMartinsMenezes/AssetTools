using System.Text.Json;

namespace AssetTool
{
    public class FClassPtrProperty : FClassProperty
    {
        public new const string TYPE_NAME = "ClassPtrProperty";
        public override string TypeName => TYPE_NAME;

        [Location("void FClassPtrProperty::SerializeItem(FStructuredArchive::FSlot Slot, void* Value, void const* Defaults) const")]
        public override FField Move(Transfer transfer)
        {
            return base.Move(transfer);
        }

        public override FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            string key = elem.Name;

            JsonElement value = elem.Value;

            var obj = ReadKeyValue<FClassPtrProperty>(key, value);

            obj.ElementSize = 8;

            obj.Value = key.GetNonNull("Value({0})", x => FObjectPtr.FromString(x), new FObjectPtr { Index = new FPackageIndex() });
            obj.MetaClass = key.GetNonNull("MetaClass({0})", x => uint.Parse(x), (uint)0);

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            Dictionary<string, object> inlineFields = new()
            {
                ["Value"] = this.Value,
                ["MetaClass"] = this.MetaClass
            };

            WriteKeyValue(writer, options, this, "prop-classptr", inlineFields);
        }
    }
}
