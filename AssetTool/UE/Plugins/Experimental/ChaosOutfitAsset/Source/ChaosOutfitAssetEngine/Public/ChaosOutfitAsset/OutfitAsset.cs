namespace AssetTool
{
    [JsonAsset("ChaosOutfitAsset")]
    public class UChaosOutfitAsset : UChaosClothAssetBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}