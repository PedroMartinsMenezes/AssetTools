namespace AssetTool
{
    [JsonAsset("MassSignalSubsystem")]
    public class UMassSignalSubsystem : UMassTickableSubsystemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}