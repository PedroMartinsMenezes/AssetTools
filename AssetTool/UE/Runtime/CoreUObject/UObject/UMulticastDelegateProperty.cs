namespace AssetTool
{
    [JsonAsset("MulticastDelegateProperty")]
    public class UMulticastDelegateProperty : UProperty
    {
        public UInt32 SignatureFunction;

        [Location("void UMulticastDelegateProperty::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SignatureFunction);
            return this;
        }
    }
}
