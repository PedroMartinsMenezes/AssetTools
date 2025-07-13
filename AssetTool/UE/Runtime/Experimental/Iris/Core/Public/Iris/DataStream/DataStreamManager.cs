namespace AssetTool
{
    [JsonAsset("DataStreamManager")]
    public class UDataStreamManager : UDataStream
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}