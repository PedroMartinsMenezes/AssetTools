namespace AssetTool
{
    [JsonAsset("WorldMetricsActorTracker")]
    public class UWorldMetricsActorTracker : UWorldMetricsExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}