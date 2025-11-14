namespace AssetTool
{
    [JsonAsset("InterchangeAssetUserData")]
    public class UInterchangeAssetUserData : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}