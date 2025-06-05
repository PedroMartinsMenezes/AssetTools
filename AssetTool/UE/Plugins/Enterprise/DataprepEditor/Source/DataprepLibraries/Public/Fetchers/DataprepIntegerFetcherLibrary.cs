namespace AssetTool
{
    [JsonAsset("DataprepTriangleCountFetcher")]
    public class UDataprepTriangleCountFetcher : UDataprepIntegerFetcher
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataprepVertexCountFetcher")]
    public class UDataprepVertexCountFetcher : UDataprepIntegerFetcher
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}