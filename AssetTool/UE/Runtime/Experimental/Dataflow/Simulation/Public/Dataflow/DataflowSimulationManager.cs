namespace AssetTool
{
    [JsonAsset("DataflowSimulationManager")]
    public class UDataflowSimulationManager : UTickableWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}