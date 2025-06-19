namespace AssetTool
{
    [JsonAsset("CaptureCardMediaSource")]
    public class UCaptureCardMediaSource : UTimeSynchronizableMediaSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}