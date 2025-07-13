namespace AssetTool
{
    [JsonAsset("MediaBundleTimeSynchronizationSource")]
    public class UMediaBundleTimeSynchronizationSource : UTimeSynchronizationSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}