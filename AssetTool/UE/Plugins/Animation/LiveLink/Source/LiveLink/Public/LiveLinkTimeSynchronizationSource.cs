namespace AssetTool
{
    [JsonAsset("LiveLinkTimeSynchronizationSource")]
    public class ULiveLinkTimeSynchronizationSource : UTimeSynchronizationSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}