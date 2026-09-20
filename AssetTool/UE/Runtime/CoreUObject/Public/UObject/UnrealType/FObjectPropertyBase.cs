using System.ComponentModel;
using System.Text.Json;

namespace AssetTool
{
    public class FObjectPropertyBase : FProperty
    {
        public new const string TYPE_NAME = "ObjectPropertyBase";
        public override string TypeName => TYPE_NAME;

        [Description("TObjectPtr<class UClass> PropertyClass;")]
        public Int32 PropertyClass;

        [Location("void FObjectPropertyBase::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref PropertyClass);
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

            var obj = ReadKeyValue<FObjectPropertyBase>(key, value);

            obj.ElementSize = 8;

            obj.PropertyClass = key.GetNonNull("PropertyClass({0})", x => int.Parse(x));

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            Dictionary<string, object> inlineFields = new()
            {
                ["PropertyClass"] = this.PropertyClass
            };

            WriteKeyValue(writer, options, this, "prop-object-base", inlineFields);

            writer.WriteEndObject();
        }
    }
}
