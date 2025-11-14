namespace AssetTool
{
    [JsonAsset("TimeSynchronizableMediaSource")]
    public class UTimeSynchronizableMediaSource : UBaseMediaSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}