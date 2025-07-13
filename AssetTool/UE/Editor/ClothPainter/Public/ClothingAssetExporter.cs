namespace AssetTool
{
    [JsonAsset("ClothingAssetExporter")]
    public class UClothingAssetExporter : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}