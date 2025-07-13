namespace AssetTool
{
    [JsonAsset("MassDebuggerSubsystem")]
    public class UMassDebuggerSubsystem : UMassSubsystemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}