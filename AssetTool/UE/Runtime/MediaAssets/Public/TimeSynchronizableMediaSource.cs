namespace AssetTool
{
    [JsonAsset("TimeSynchronizableMediaSource")]
    public class UTimeSynchronizableMediaSource : UBaseMediaSource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}