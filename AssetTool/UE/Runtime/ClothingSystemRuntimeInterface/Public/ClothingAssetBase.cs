namespace AssetTool
{
    [JsonAsset("ClothingAssetBase")]
    public class UClothingAssetBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}