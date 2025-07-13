namespace AssetTool
{
    [JsonAsset("ClothingAssetFactory")]
    public class UClothingAssetFactory : UClothingAssetFactoryBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}