namespace AssetTool
{
    [JsonAsset("DataStreamManager")]
    public class UDataStreamManager : UDataStream
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}