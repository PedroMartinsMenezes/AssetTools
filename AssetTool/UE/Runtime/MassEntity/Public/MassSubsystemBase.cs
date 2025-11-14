namespace AssetTool
{
    [JsonAsset("MassSubsystemBase")]
    public class UMassSubsystemBase : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassTickableSubsystemBase")]
    public class UMassTickableSubsystemBase : UTickableWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}