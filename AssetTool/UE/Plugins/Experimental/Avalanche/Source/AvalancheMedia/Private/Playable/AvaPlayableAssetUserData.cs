namespace AssetTool
{
    [JsonAsset("AvaPlayableAssetUserData")]
    public class UAvaPlayableAssetUserData : UAssetUserData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}