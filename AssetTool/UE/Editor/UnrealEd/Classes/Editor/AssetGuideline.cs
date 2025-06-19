namespace AssetTool
{
    [JsonAsset("AssetGuideline")]
    public class UAssetGuideline : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}