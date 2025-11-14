namespace AssetTool
{
    [JsonAsset("AjaMediaSource")]
    public class UAjaMediaSource : UCaptureCardMediaSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}