namespace AssetTool
{
    [JsonAsset("DataprepAsset")]
    public class UDataprepAsset : UDataprepAssetInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}