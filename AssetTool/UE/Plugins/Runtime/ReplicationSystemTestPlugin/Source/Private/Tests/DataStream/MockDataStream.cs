namespace AssetTool
{
    [JsonAsset("MockDataStream")]
    public class UMockDataStream : UDataStream
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}