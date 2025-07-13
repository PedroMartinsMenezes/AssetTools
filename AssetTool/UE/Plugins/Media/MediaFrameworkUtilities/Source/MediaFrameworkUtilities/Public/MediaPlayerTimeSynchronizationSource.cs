namespace AssetTool
{
    [JsonAsset("MediaPlayerTimeSynchronizationSource")]
    public class UMediaPlayerTimeSynchronizationSource : UTimeSynchronizationSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}