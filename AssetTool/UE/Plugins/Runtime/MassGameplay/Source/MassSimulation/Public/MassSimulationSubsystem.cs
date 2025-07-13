namespace AssetTool
{
    [JsonAsset("MassSimulationSubsystem")]
    public class UMassSimulationSubsystem : UMassSubsystemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}