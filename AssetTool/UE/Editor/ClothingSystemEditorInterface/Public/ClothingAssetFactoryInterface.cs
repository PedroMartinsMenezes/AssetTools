namespace AssetTool
{
    [JsonAsset("ClothingAssetFactoryBase")]
    public class UClothingAssetFactoryBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}