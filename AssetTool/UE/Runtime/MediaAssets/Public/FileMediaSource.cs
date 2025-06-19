namespace AssetTool
{
    [JsonAsset("FileMediaSource")]
    public class UFileMediaSource : UBaseMediaSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}