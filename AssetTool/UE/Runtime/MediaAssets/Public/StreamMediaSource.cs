namespace AssetTool
{
    [JsonAsset("StreamMediaSource")]
    public class UStreamMediaSource : UBaseMediaSource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}