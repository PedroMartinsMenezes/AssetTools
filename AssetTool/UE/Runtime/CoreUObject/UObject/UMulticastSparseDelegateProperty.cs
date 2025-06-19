namespace AssetTool
{
    [JsonAsset("MulticastSparseDelegateProperty")]
    public class UMulticastSparseDelegateProperty : UMulticastDelegateProperty
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
