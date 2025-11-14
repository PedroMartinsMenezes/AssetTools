namespace AssetTool
{
    [JsonAsset("LiveLinkTimeSynchronizationSource")]
    public class ULiveLinkTimeSynchronizationSource : UTimeSynchronizationSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}