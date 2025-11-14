namespace AssetTool
{
    [JsonAsset("DataStreamChannel")]
    public class UDataStreamChannel : UChannel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}