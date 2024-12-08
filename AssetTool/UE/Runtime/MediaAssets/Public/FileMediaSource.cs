namespace AssetTool
{
    [JsonAsset("FileMediaSource")]
    public class UFileMediaSource : UBaseMediaSource
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}