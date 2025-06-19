namespace AssetTool
{
    [JsonAsset("LandscapeMaterialInstanceConstant")]
    public class ULandscapeMaterialInstanceConstant : UMaterialInstanceConstant
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}