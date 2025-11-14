namespace AssetTool
{
    [JsonAsset("WorldMetricsActorTracker")]
    public class UWorldMetricsActorTracker : UWorldMetricsExtension
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}