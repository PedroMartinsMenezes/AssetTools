namespace AssetTool
{
    [JsonAsset("MediaSource")]
    public class UMediaSource : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}