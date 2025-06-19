namespace AssetTool
{
    [JsonAsset("DataflowSimulationManager")]
    public class UDataflowSimulationManager : UTickableWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}