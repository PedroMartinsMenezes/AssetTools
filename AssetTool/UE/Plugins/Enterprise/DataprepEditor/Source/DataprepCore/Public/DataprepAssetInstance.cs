namespace AssetTool
{
    [JsonAsset("DataprepAssetInstance")]
    public class UDataprepAssetInstance : UDataprepAssetInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}