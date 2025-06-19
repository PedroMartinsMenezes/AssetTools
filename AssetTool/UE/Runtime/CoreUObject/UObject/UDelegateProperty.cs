namespace AssetTool
{
    [JsonAsset("DelegateProperty")]
    public class UDelegateProperty : UProperty
    {
        public UInt32 SignatureFunction;

        [Location("void UDelegateProperty::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref SignatureFunction);
            return this;
        }
    }
}
