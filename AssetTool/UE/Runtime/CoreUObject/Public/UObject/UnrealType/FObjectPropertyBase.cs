using System.ComponentModel;

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
    }
}
