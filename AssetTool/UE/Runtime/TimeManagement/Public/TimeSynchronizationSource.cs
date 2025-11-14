namespace AssetTool
{
    [JsonAsset("TimeSynchronizationSource")]
    public class UTimeSynchronizationSource : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}