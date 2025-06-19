namespace AssetTool
{
    [JsonAsset("ChaosClothAsset")]
    public class UChaosClothAsset : USkinnedAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}