namespace AssetTool
{
    [JsonAsset("DataprepFilter")]
    public class UDataprepFilter : UDataprepParameterizableObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataprepFilterNoFetcher")]
    public class UDataprepFilterNoFetcher : UDataprepParameterizableObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}