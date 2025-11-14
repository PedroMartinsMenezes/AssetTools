namespace AssetTool
{
    [JsonAsset("AssetGuideline")]
    public class UAssetGuideline : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}