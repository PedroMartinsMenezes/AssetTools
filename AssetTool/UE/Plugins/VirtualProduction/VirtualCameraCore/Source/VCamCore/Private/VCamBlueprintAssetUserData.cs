namespace AssetTool
{
    [JsonAsset("VCamBlueprintAssetUserData")]
    public class UVCamBlueprintAssetUserData : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}