namespace AssetTool
{
    [JsonAsset("MassSimulationSubsystem")]
    public class UMassSimulationSubsystem : UMassSubsystemBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}