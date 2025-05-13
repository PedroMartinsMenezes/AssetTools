namespace AssetTool
{
    [JsonAsset("ChaosClothAsset")]
    public class UChaosClothAsset : USkinnedAsset
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}