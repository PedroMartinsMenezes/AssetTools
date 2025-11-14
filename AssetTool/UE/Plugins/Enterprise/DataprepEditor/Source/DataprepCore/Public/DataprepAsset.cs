namespace AssetTool
{
    [JsonAsset("DataprepAsset")]
    public class UDataprepAsset : UDataprepAssetInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}