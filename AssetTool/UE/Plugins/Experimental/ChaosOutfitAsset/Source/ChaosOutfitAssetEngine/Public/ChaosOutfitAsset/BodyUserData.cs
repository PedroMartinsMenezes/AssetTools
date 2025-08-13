namespace AssetTool
{
    [JsonAsset("ChaosOutfitAssetBodyUserData")]
    public class UChaosOutfitAssetBodyUserData : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}