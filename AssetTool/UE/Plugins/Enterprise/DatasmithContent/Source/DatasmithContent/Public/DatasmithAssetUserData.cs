namespace AssetTool
{
    [JsonAsset("DatasmithAssetUserData")]
    public class UDatasmithAssetUserData : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}