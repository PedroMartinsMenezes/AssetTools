namespace AssetTool
{
    [Location("void FObjectPropertyBase::Serialize( FArchive& Ar )")]
    public class FObjectPropertyBase : FProperty
    {
        public const string TYPE_NAME = "ObjectProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            return this;
        }
    }
}
