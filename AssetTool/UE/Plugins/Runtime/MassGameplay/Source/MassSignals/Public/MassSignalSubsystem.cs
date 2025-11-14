namespace AssetTool
{
    [JsonAsset("MassSignalSubsystem")]
    public class UMassSignalSubsystem : UMassTickableSubsystemBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}