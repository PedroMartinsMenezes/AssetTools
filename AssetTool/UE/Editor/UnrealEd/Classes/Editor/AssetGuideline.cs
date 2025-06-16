namespace AssetTool
{
    [JsonAsset("AssetGuideline")]
    public class UAssetGuideline : UAssetUserData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}