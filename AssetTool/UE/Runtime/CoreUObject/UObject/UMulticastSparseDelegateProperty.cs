namespace AssetTool
{
    [JsonAsset("MulticastSparseDelegateProperty")]
    public class UMulticastSparseDelegateProperty : UMulticastDelegateProperty
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
