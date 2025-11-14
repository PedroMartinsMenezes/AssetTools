namespace AssetTool
{
    [JsonAsset("DatasmithAssetUserData")]
    public class UDatasmithAssetUserData : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}