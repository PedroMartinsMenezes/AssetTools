namespace AssetTool
{
    [JsonAsset("AvaPlayableAssetUserData")]
    public class UAvaPlayableAssetUserData : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}