using System.ComponentModel;

namespace AssetTool
{
    public class FObjectPropertyBase : FProperty
    {
        public new const string TYPE_NAME = "ObjectPropertyBase";
        public override string TypeName => TYPE_NAME;

        [Description("TObjectPtr<class UClass> PropertyClass;")]
        public UInt32 PropertyClass;

        [Location("void FObjectPropertyBase::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref PropertyClass);
            return this;
        }

        public static UInt32 MoveValue(Transfer transfer, UInt32 value)
        {
            transfer.Move(ref value);
            return value;
        }
    }
}
