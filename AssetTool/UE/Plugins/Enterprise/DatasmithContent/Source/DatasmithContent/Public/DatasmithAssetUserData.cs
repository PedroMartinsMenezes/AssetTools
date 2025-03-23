namespace AssetTool
{
    [JsonAsset("DatasmithAssetUserData")]
    public class UDatasmithAssetUserData : UAssetUserData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}