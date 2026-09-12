using System.ComponentModel;
using System.Diagnostics;
using System.Text.Json;

namespace AssetTool
{
    [DebuggerDisplay("{TypeName}<{PropertyTypeName}> {NamePrivate.ToString()}")]
    public class FEnumProperty : FProperty
    {
        public new const string TYPE_NAME = "EnumProperty";
        public override string TypeName => TYPE_NAME;

        [Description("TObjectPtr<UEnum> Enum")] public UInt32 Value;
        public FName PropertyTypeName;
        public FField SingleField;

        [Location("void FEnumProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            FField.SerializeSingleField(transfer, ref PropertyTypeName, ref SingleField);
            return this;
        }

        public static FName MoveValue(Transfer transfer, FName value)
        {
            transfer.Move(ref value);
            return value;
        }

        public static T MoveEnumValue<T>(Transfer transfer, T value) where T : struct
        {
            transfer.MoveEnum(ref value);
            return value;
        }
    }

    public class FEnumPropertySerializer : FPropertySerializerBase<FEnumProperty>
    {
        public FEnumProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            var obj = ReadBaseProperties(root);
            obj.ElementSize = 1;
            obj.Value = root.GetProperty("Value").GetUInt32();
            obj.PropertyTypeName = new FName(root.GetProperty("PropertyTypeName").GetString());
            obj.SingleField = JsonSerializer.Deserialize<FField>(root.GetProperty("SingleField").GetRawText(), options);
            return obj;
        }

        public void Write(Utf8JsonWriter writer, FEnumProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            WriteBaseProperties(writer, value);
            writer.WriteNumber("Value", value.Value);
            writer.WriteString("PropertyTypeName", value.PropertyTypeName.ToString());
            writer.WritePropertyName("SingleField");
            JsonSerializer.Serialize(writer, value.SingleField, options);
            writer.WriteEndObject();
        }
    }
}
