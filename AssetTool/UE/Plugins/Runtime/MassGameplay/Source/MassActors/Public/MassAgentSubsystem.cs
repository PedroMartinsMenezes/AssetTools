namespace AssetTool
{
    [JsonAsset("MassAgentSubsystem")]
    public class UMassAgentSubsystem : UMassSubsystemBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}