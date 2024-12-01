namespace AssetTool
{
    [JsonAsset("LandscapeMaterialInstanceConstant")]
    public class ULandscapeMaterialInstanceConstant : UMaterialInstanceConstant
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}