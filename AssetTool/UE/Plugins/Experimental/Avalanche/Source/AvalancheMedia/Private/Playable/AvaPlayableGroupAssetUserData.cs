namespace AssetTool
{
    [JsonAsset("AvaPlayableGroupAssetUserData")]
    public class UAvaPlayableGroupAssetUserData : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}