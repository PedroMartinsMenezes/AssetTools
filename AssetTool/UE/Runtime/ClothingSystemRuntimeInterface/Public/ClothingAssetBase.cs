namespace AssetTool
{
    [JsonAsset("ClothingAssetBase")]
    public class UClothingAssetBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}