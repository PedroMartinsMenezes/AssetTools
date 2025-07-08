namespace AssetTool
{
    [JsonAsset("AjaMediaSource")]
    public class UAjaMediaSource : UCaptureCardMediaSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}