namespace AssetTool
{
    [JsonAsset("MediaPlayerTimeSynchronizationSource")]
    public class UMediaPlayerTimeSynchronizationSource : UTimeSynchronizationSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}