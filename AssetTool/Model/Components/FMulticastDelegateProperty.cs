namespace AssetTool
{
    [Location("void FMulticastDelegateProperty::Serialize( FArchive& Ar )")]
    public class FMulticastDelegateProperty : FProperty
    {
        public UInt32 SignatureFunction;

        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SignatureFunction);
            return this;
        }
    }
}
