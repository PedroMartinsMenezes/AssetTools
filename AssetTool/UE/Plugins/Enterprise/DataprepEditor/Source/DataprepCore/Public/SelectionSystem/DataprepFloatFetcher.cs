namespace AssetTool
{
    [JsonAsset("DataprepFloatFetcher")]
    public class UDataprepFloatFetcher : UDataprepFetcher
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}