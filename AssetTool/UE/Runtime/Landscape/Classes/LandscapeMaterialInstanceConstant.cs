namespace AssetTool
{
    [JsonAsset("LandscapeMaterialInstanceConstant")]
    public class ULandscapeMaterialInstanceConstant : UMaterialInstanceConstant
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}