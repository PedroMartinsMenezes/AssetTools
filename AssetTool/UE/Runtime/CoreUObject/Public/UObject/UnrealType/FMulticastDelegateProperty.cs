namespace AssetTool
{
    public class FMulticastDelegateProperty : FProperty
    {
        public new const string TYPE_NAME = "MulticastDelegateProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 SignatureFunction;
        public Dictionary<FObjectPtr, FName> Delegates;

        [Location("void FMulticastDelegateProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SignatureFunction);
            return this;
        }

        public FMulticastDelegateProperty MoveValue(Transfer transfer)
        {
            transfer.Move(ref Delegates);
            return this;
        }
    }
}
