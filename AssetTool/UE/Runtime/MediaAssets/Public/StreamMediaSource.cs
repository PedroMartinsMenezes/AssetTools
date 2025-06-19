namespace AssetTool
{
    [JsonAsset("StreamMediaSource")]
    public class UStreamMediaSource : UBaseMediaSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}