namespace AssetTool
{
    [JsonAsset("MediaBundleTimeSynchronizationSource")]
    public class UMediaBundleTimeSynchronizationSource : UTimeSynchronizationSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}