namespace AssetTool
{
    [JsonAsset("InterchangeAssetUserData")]
    public class UInterchangeAssetUserData : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}