using System.Text.Json;

namespace AssetTool
{
    public class FObjectProperty : FProperty
    {
        public new const string TYPE_NAME = "ObjectProperty";
        public override string TypeName => TYPE_NAME;

        public FObjectPtr Value;

        [Location("void FObjectPropertyBase::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }

        public static Int32 MoveValue(Transfer transfer, Int32 value)
        {
            transfer.Move(ref value);
            return value;
        }

        public override FProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue<FObjectProperty>(key, value);

            obj.ElementSize = 8;

            obj.Value = key.GetNonNull("Value({0})", x => FObjectPtr.FromString(x), new FObjectPtr { Index = new FPackageIndex() });

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            Dictionary<string, object> inlineFields = new()
            {
                ["Value"] = this.Value
            };

            WriteKeyValue(writer, options, this, "prop-object", inlineFields);

            writer.WriteEndObject();
        }
    }
}
