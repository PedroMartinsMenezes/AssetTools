namespace AssetTool
{
    [JsonAsset("CaptureCardMediaSource")]
    public class UCaptureCardMediaSource : UTimeSynchronizableMediaSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}