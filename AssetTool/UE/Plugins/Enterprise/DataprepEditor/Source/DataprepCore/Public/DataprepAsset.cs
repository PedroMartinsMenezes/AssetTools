namespace AssetTool
{
    [JsonAsset("DataprepAsset")]
    public class UDataprepAsset : UDataprepAssetInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}