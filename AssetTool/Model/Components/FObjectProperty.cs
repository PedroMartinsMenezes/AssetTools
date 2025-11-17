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
    }
}
