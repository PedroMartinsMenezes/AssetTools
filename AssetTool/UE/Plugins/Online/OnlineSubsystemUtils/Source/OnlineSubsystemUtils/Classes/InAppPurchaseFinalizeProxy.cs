namespace AssetTool
{
    [JsonAsset("InAppPurchaseFinalizeProxy")]
    public class UInAppPurchaseFinalizeProxy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}