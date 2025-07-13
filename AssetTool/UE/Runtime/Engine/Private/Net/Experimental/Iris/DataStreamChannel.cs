namespace AssetTool
{
    [JsonAsset("DataStreamChannel")]
    public class UDataStreamChannel : UChannel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}