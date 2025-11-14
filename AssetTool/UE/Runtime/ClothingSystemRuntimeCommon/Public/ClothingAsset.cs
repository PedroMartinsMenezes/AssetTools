namespace AssetTool
{
    [JsonAsset("ClothingAssetCustomData")]
    public class UClothingAssetCustomData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ClothingAssetCommon")]
    public class UClothingAssetCommon : UClothingAssetBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}