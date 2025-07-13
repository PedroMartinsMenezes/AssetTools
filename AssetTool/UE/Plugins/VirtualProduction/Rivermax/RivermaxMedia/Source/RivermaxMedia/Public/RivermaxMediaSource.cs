namespace AssetTool
{
    [JsonAsset("RivermaxMediaSource")]
    public class URivermaxMediaSource : UCaptureCardMediaSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}