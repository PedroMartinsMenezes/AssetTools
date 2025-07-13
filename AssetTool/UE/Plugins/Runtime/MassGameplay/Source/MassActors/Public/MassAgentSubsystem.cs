namespace AssetTool
{
    [JsonAsset("MassAgentSubsystem")]
    public class UMassAgentSubsystem : UMassSubsystemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}