using System.ComponentModel;
using System.Diagnostics;

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
}
