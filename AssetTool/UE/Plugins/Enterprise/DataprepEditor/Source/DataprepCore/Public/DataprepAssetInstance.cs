namespace AssetTool
{
    [JsonAsset("DataprepAssetInstance")]
    public class UDataprepAssetInstance : UDataprepAssetInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}