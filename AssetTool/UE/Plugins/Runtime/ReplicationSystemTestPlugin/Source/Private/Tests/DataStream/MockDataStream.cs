namespace AssetTool
{
    [JsonAsset("MockDataStream")]
    public class UMockDataStream : UDataStream
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}