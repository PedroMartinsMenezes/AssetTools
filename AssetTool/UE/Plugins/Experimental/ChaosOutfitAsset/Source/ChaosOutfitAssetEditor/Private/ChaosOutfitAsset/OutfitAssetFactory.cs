namespace AssetTool
{
    [JsonAsset("ChaosOutfitAssetFactory")]
    public class UChaosOutfitAssetFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}