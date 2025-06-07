namespace AssetTool
{
    [JsonAsset("InterchangeAssetUserData")]
    public class UInterchangeAssetUserData : UAssetUserData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}