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

        public override FProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;
            JsonElement value = root.EnumerateObject().First().Value;
            var obj = ReadKeyValue<FEnumProperty>(key, value);
            obj.ElementSize = 1;
            obj.Value = key.GetNonNull("Value({0})", x => uint.Parse(x), (uint)0);
            obj.PropertyTypeName = key.GetNonNull("PropertyTypeName({0})", x => new FName(x));
            obj.SingleField = new FByteProperty
            {
                ArrayDim = 1,
                PropertyFlags = EPropertyFlags.CPF_None,
                RepIndex = 0,
                RepNotifyFunc = new FName("None"),
                BlueprintReplicationCondition = 0,
                FlagsPrivate = EObjectFlags.RF_Public,
                HasMetaData = false,
                ElementSize = 1,
                NamePrivate = new FName("UnderlyingType")
            };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            Dictionary<string, object> inlineFields = new()
            {
                ["Value"] = this.Value,
                ["PropertyTypeName"] = this.PropertyTypeName
            };
            WriteKeyValue(writer, options, this, "prop-enum", inlineFields);
            writer.WriteEndObject();
        }
    }
}
