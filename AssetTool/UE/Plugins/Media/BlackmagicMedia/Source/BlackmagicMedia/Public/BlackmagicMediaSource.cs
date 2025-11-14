namespace AssetTool
{
    [JsonAsset("BlackmagicMediaSource")]
    public class UBlackmagicMediaSource : UCaptureCardMediaSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}