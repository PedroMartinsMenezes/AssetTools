namespace AssetTool
{
    [JsonAsset("ClothingAssetFactory")]
    public class UClothingAssetFactory : UClothingAssetFactoryBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}