namespace AssetTool
{
    [JsonAsset("TimeSynchronizationSource")]
    public class UTimeSynchronizationSource : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}