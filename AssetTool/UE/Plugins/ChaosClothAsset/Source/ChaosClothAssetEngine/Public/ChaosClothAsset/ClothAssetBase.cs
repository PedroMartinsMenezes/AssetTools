namespace AssetTool
{
    [JsonAsset("ChaosClothAssetBase")]
    public class UChaosClothAssetBase : USkinnedAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}