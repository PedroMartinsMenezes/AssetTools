namespace AssetTool
{
    [JsonAsset("VCamBlueprintAssetUserData")]
    public class UVCamBlueprintAssetUserData : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}