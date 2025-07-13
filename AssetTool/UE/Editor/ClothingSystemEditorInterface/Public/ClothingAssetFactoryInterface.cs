namespace AssetTool
{
    [JsonAsset("ClothingAssetFactoryBase")]
    public class UClothingAssetFactoryBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}