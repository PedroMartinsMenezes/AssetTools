namespace AssetTool
{
    [JsonAsset("AvaPlayableAssetUserData")]
    public class UAvaPlayableAssetUserData : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}