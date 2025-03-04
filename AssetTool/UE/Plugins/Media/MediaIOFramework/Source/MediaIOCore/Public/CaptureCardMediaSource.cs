namespace AssetTool
{
    [JsonAsset("CaptureCardMediaSource")]
    public class UCaptureCardMediaSource : UTimeSynchronizableMediaSource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}