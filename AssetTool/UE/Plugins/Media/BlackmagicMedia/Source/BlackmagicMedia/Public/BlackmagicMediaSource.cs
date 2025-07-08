namespace AssetTool
{
    [JsonAsset("BlackmagicMediaSource")]
    public class UBlackmagicMediaSource : UCaptureCardMediaSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}