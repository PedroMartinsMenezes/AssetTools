namespace AssetTool
{
    [JsonAsset("DataprepAssetUserData")]
    public class UDataprepAssetUserData : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}