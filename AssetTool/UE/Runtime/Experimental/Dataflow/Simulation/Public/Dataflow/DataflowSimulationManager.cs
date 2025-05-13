namespace AssetTool
{
    [JsonAsset("DataflowSimulationManager")]
    public class UDataflowSimulationManager : UTickableWorldSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}