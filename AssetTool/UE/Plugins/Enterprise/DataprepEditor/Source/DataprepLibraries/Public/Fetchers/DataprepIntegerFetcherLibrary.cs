namespace AssetTool
{
    [JsonAsset("DataprepTriangleCountFetcher")]
    public class UDataprepTriangleCountFetcher : UDataprepIntegerFetcher
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataprepVertexCountFetcher")]
    public class UDataprepVertexCountFetcher : UDataprepIntegerFetcher
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}