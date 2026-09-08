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
            var obj = ReadBaseProperties(root);
            obj.ElementSize = root.GetProperty("ElementSize").GetInt32();
            obj.PropertyTypeName = new FName(root.GetProperty("PropertyTypeName").GetString());
            if (root.TryGetProperty("SingleField", out var singleField) && singleField.ValueKind == JsonValueKind.Object)
            {
                obj.SingleField = JsonSerializer.Deserialize<FField>(singleField.GetRawText(), options);
            }
            return obj;
        }

        public void Write(Utf8JsonWriter writer, FArrayProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            WriteBaseProperties(writer, value);
            writer.WriteNumber("ElementSize", value.ElementSize);
            writer.WriteString("PropertyTypeName", value.PropertyTypeName.ToString());

            writer.WritePropertyName("SingleField");
            JsonSerializer.Serialize(writer, value.SingleField, options);

            writer.WriteEndObject();
        }
    }
}
