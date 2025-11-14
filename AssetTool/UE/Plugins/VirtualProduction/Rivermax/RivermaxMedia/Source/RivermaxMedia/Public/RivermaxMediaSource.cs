namespace AssetTool
{
    [JsonAsset("RivermaxMediaSource")]
    public class URivermaxMediaSource : UCaptureCardMediaSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}