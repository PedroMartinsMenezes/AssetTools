namespace AssetTool
{
    [JsonAsset("TimeSynchronizableMediaSource")]
    public class UTimeSynchronizableMediaSource : UBaseMediaSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}