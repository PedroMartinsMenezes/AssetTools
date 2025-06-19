namespace AssetTool
{
    [JsonAsset("DataprepAssetUserData")]
    public class UDataprepAssetUserData : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}