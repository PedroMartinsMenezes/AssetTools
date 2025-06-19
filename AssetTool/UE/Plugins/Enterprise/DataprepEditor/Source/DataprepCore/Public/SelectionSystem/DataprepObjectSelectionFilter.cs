namespace AssetTool
{
    [JsonAsset("DataprepObjectSelectionFilter")]
    public class UDataprepObjectSelectionFilter : UDataprepFilterNoFetcher
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}