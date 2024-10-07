namespace AssetTool
{
    public class FDelegateProperty : FProperty
    {
        public new const string TYPE_NAME = "DelegateProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 SignatureFunction;

        [Location("void FDelegateProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SignatureFunction);
            return this;
        }
    }
}
